using SwiftlyS2.Shared.Plugins;
using SwiftlyS2.Shared;
using SwiftlyS2.Shared.Convars;
using SwiftlyS2.Shared.Commands;
using SwiftlyS2.Shared.Events;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.Misc;
using SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

namespace Profiler;

[PluginMetadata(Id = "Profiler", Version = "1.0.0", Name = "Profiler", Author = "Swiftly Development Team", Description = "No description.")]
public partial class Profiler : BasePlugin
{
    public static int MaxEntities = 1024;
    public static int AddBots = 30; // by default there are 1 bot and 1 player spawned
    public static int BotQuota = 32;
    public bool IsTestInProgress = false;
    public float StartMemory = 0.0f;
    public float EndMemory = 0.0f;

    public IConVar<int>? BotQuotaConVar;
    public ProfileServices profilerService = new();

    public Profiler(ISwiftlyCore core) : base(core)
    {
    }

    public override void ConfigureSharedInterface(IInterfaceManager interfaceManager)
    {
    }

    public override void UseSharedInterface(IInterfaceManager interfaceManager)
    {
    }

    public override void Load(bool hotReload)
    {
        profilerService.Enable();
        BotQuotaConVar = Core.ConVar.Find<int>("bot_quota");
    }

    public override void Unload()
    {
    }

    [Command("preparetest")]
    public void PrepareTestCommand(ICommandContext context)
    {
        BotQuotaConVar?.Value = BotQuota;
        for (int i = 0; i < AddBots; i++)
        {
            Core.Engine.ExecuteCommand("bot_add");
        }

        context.Reply($"Added {AddBots} bots for profiling test. Current bot quota is {BotQuotaConVar?.Value}. Total player count: {Core.PlayerManager.GetAllPlayers().Count()}");
    }

    [Command("starttest")]
    public void StartTestCommand(ICommandContext context)
    {
        StartMemory = GC.GetTotalMemory(true) / (1024.0f * 1024.0f);
        IsTestInProgress = true;

        CreateEntities();
        SpawnEntities();

        SchemaWriteEntities();
        SchemaReadEntities();
        VirtualCallEntities();

    }

    [Command("endtest")]
    public void EndTestCommand(ICommandContext context)
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

    [Command("savetest")]
    public void SaveTestCommand(ICommandContext context)
    {
        var json = profilerService.GenerateJSONPerformance("");
        File.WriteAllText("profiler_output.json", json);
        Console.WriteLine("Profiler data saved to profiler_output.json");
    }

    [EventListener<EventDelegates.OnEntitySpawned>]
    public void OnEntitySpawned(IOnEntitySpawnedEvent @event)
    {
        if (!IsTestInProgress) return;

        DespawnEntity(@event.Entity.As<CBaseEntity>());
    }

    [EventListener<EventDelegates.OnTick>]
    public void OnTick()
    {
        if (!IsTestInProgress) return;

        GetGameRules();
        TeleportAllGameEntities();

        FindConvar();
        ReadConvar();
        WriteConvar();

        var players = Core.PlayerManager.GetAllPlayers();
        foreach (var player in players)
        {
            ReplicateConvarToClient(player.PlayerID);
        }

        FireGameEventsToPlayer();

        SendNetMessages();
    }

    [ServerNetMessageHandler]
    public HookResult NetMessageHandler(CMsgSosStartSoundEvent msg)
    {
        if (!IsTestInProgress) return HookResult.Continue;
        CMsgSosStartSoundEventHandler(msg);
        return HookResult.Continue;
    }

    [ClientNetMessageHandler]
    public HookResult ClientNetMessageHandler(CCLCMsg_Move msg, int playerid)
    {
        if (!IsTestInProgress) return HookResult.Continue;
        CCLCMsg_MoveHandler(msg, playerid);
        return HookResult.Continue;
    }
}