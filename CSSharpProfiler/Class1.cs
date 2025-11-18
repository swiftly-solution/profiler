using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Commands;
using CounterStrikeSharp.API.Modules.Cvars;
using static CounterStrikeSharp.API.Core.Listeners;

namespace CSSharpProfiler;

public partial class CSSharpProfiler : BasePlugin
{
    public static int MaxEntities = 1024;
    public static int AddBots = 30; // by default there are 1 bot and 1 player spawned
    public static int BotQuota = 32;
    public bool IsTestInProgress = false;
    public float StartMemory = 0.0f;
    public float EndMemory = 0.0f;

    public ConVar? BotQuotaConVar;

    public override string ModuleName => "CSSharpProfiler";
    public override string ModuleVersion => "1.0.0";

    private ProfileService profilerService = new();

    public override void Load(bool hotReload)
    {
        profilerService.Enable();

        RegisterListener<OnEntitySpawned>((entity) =>
        {
            if (!IsTestInProgress) return;

            DespawnEntity(entity.As<CBaseEntity>());
        });

        RegisterListener<OnTick>(() =>
        {
            if (!IsTestInProgress) return;

            GetGameRules();
            TeleportAllGameEntities();

            FindConvar();
            ReadConvar();
            WriteConvar();

            var players = Utilities.GetPlayers();
            foreach (var player in players)
            {
                ReplicateConvarToClient(player.UserId!.Value);
            }

            FireGameEventsToPlayer();

            SendNetMessages();
        });

        HookUserMessage(208, (msg) =>
        {
            if (!IsTestInProgress) return HookResult.Continue;
            CMsgSosStartSoundEventHandler(msg);
            return HookResult.Continue;
        });
    }

    [ConsoleCommand("preparetest", "")]
    public void PrepareTestCommand(CCSPlayerController? player, CommandInfo command)
    {
        var cvar = ConVar.Find("bot_quota");
        cvar!.SetValue(BotQuota);

        for (int i = 0; i < AddBots; i++)
        {
            Server.ExecuteCommand("bot_add");
        }

        Console.WriteLine($"Added {AddBots} bots for profiling test. Current bot quota is {cvar.StringValue}. Total player count: {Utilities.GetPlayers().Count}");
    }

    [ConsoleCommand("savetest", "")]
    public void SaveTestCommand(CCSPlayerController? player, CommandInfo command)
    {
        var json = profilerService.GenerateJSONPerformance("");
        File.WriteAllText("profiler_output.json", json);
        Console.WriteLine("Profiler data saved to profiler_output.json");
    }

    [ConsoleCommand("starttest", "")]
    public void StartTestCommand(CCSPlayerController? player, CommandInfo command)
    {
        StartMemory = GC.GetTotalMemory(true) / (1024.0f * 1024.0f);
        IsTestInProgress = true;

        CreateEntities();
        SpawnEntities();

        SchemaWriteEntities();
        SchemaReadEntities();
        VirtualCallEntities();
    }

    [ConsoleCommand("endtest", "")]
    public void EndTestCommand(CCSPlayerController? player, CommandInfo command)
    {
        IsTestInProgress = false;

        EndMemory = GC.GetTotalMemory(false) / (1024.0f * 1024.0f);
        GC.Collect();
        float MemoryAfterGC = GC.GetTotalMemory(false) / (1024.0f * 1024.0f);

        Console.WriteLine("=== Profiler Test Memory Usage ===");
        Console.WriteLine($"Memory Before Test: {StartMemory} MB");
        Console.WriteLine($"Memory After Test: {EndMemory} MB");
        Console.WriteLine($"Memory After GC: {MemoryAfterGC} MB");
    }
}