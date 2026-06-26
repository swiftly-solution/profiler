using System;
using System.IO;
using Plugify;
using s2sdk;
using static s2sdk.s2sdk;

namespace PlugifyProfiler;

public unsafe partial class PlugifyProfiler : Plugin
{
    public static int MaxEntities = 1024;
    public static int AddBots = 30; // by default there are 1 bot and 1 player spawned
    public static int BotQuota = 32;
    public bool IsTestInProgress = false;
    public float StartMemory = 0.0f;
    public float EndMemory = 0.0f;

    internal ConVar? BotQuotaConVar;

    private ProfileService profilerService = new();

    public void OnPluginStart()
    {
        profilerService.Enable();

        OnEntityCreated_Register((entity) =>
        {
            if (!IsTestInProgress) return;

            DespawnEntity(entity);
        });

        OnGameFrame_Register((simulating, firstTick, lastTick) =>
        {
            if (!IsTestInProgress) return;

            GetGameRules();
            TeleportAllGameEntities();

            FindConvar();
            ReadConvar();
            WriteConvar();

            var players = GetMaxClients();
            for (int i = 1; i <= players; i++)
            {
                ReplicateConvarToClient(i);
            }

            FireGameEventsToPlayer();

            SendNetMessages();
        });

        var flags = ConVarFlag.LinkedConcommand | ConVarFlag.Release | ConVarFlag.ClientCanExecute;
        AddConsoleCommand("preparetest", "", flags, PrepareTestCommand, HookMode.Post);
        AddConsoleCommand("savetest", "", flags, SaveTestCommand, HookMode.Post);
        AddConsoleCommand("starttest", "", flags, StartTestCommand, HookMode.Post);
        AddConsoleCommand("endtest", "", flags, EndTestCommand, HookMode.Post);
        
        HookUserMessage(208, (msg) =>
        {
            if (!IsTestInProgress) return ResultType.Continue;
            CMsgSosStartSoundEventHandler(new UserMessage(msg));
            return ResultType.Continue;
        }, HookMode.Post);
    }

    public ResultType PrepareTestCommand(int caller, CommandCallingContext context, string[] arguments)
    {
        var cvar = ConVar.Find("bot_quota");
        cvar.SetValue(BotQuota.ToString(), false, false);

        for (int i = 0; i < AddBots; i++)
        {
            ServerCommand("bot_add");
        }

        Console.WriteLine($"Added {AddBots} bots for profiling test. Current bot quota is {cvar.GetValue()}. Total player count: {GetMaxClients()}");
        return ResultType.Continue;
    }

    public ResultType SaveTestCommand(int caller, CommandCallingContext context, string[] arguments)
    {
        var json = profilerService.GenerateJSONPerformance("");
        File.WriteAllText("profiler_output.json", json);
        Console.WriteLine("Profiler data saved to profiler_output.json");
        return ResultType.Continue;
    }

    public ResultType StartTestCommand(int caller, CommandCallingContext context, string[] arguments)
    {
        StartMemory = GC.GetTotalMemory(true) / (1024.0f * 1024.0f);
        IsTestInProgress = true;

        CreateEntities();
        SpawnEntities();

        SchemaWriteEntities();
        SchemaReadEntities();
        VirtualCallEntities();
        return ResultType.Continue;
    }

    public ResultType EndTestCommand(int caller, CommandCallingContext context, string[] arguments)
    {
        IsTestInProgress = false;

        EndMemory = GC.GetTotalMemory(false) / (1024.0f * 1024.0f);
        GC.Collect();
        float MemoryAfterGC = GC.GetTotalMemory(false) / (1024.0f * 1024.0f);

        Console.WriteLine("=== Profiler Test Memory Usage ===");
        Console.WriteLine($"Memory Before Test: {StartMemory} MB");
        Console.WriteLine($"Memory After Test: {EndMemory} MB");
        Console.WriteLine($"Memory After GC: {MemoryAfterGC} MB");
        return ResultType.Continue;
    }
}