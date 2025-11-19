using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sharp.Extensions.GameEventManager;
using Sharp.Shared;
using Sharp.Shared.Enums;
using Sharp.Shared.GameEntities;
using Sharp.Shared.HookParams;
using Sharp.Shared.Listeners;
using Sharp.Shared.Managers;
using Sharp.Shared.Objects;
using Sharp.Shared.Types;
using Sharp.Shared.Units;

namespace ModSharpProfiler;

public partial class ModSharpProfiler : IModSharpModule, IEntityListener, IEventListener
{
    public static int MaxEntities = 1024;
    public static int AddBots = 30; // by default there are 1 bot and 1 player spawned
    public static int BotQuota = 32;
    public bool IsTestInProgress = false;
    public float StartMemory = 0.0f;
    public float EndMemory = 0.0f;

    private List<IBaseEntity> allEntities = new();

    private readonly ISharedSystem _sharedSystem;

    private readonly IHookManager _hooks;
    private readonly IModSharp _modSharp;
    private readonly IEntityManager _entityManager;
    private readonly IGameEventManager _gameEventManager;

    private readonly IServiceProvider _provider;

    private ProfileService profilerService = new();

    public string DisplayName => "ModSharpProfiler";

    public string DisplayAuthor => "Swiftly Development Team";

    public int ListenerVersion => IEntityListener.ApiVersion;

    public int ListenerPriority => 0;

    public ModSharpProfiler(ISharedSystem sharedSystem, string dllPath, string sharpPath, Version version, IConfiguration configuration, bool hotReload)
    {
        _sharedSystem = sharedSystem;
        _hooks = sharedSystem.GetHookManager();
        _modSharp = sharedSystem.GetModSharp();
        _entityManager = sharedSystem.GetEntityManager();

        var services = new ServiceCollection();
        services.AddSingleton(sharedSystem);
        services.AddGameEventManager();

        _provider = services.BuildServiceProvider();
        _gameEventManager = _provider.GetRequiredService<IGameEventManager>();

    }

    public bool Init()
    {
        profilerService.Enable();

        _sharedSystem.GetEntityManager().InstallEntityListener(this);
        _sharedSystem.GetConVarManager().CreateConsoleCommand("savetest", OnSaveProfiler);
        _sharedSystem.GetConVarManager().CreateConsoleCommand("preparetest", OnPrepareTest);
        _sharedSystem.GetConVarManager().CreateConsoleCommand("starttest", OnStartTest);
        _sharedSystem.GetConVarManager().CreateConsoleCommand("endtest", OnStopTest);

        _hooks.PostEventAbstract.InstallHookPre(OnSendNetMessage);
        _modSharp.HookNetMessage(ProtobufNetMessageType.GE_SosStartSoundEvent);

        _modSharp.InstallGameFrameHook((a, b, c) =>
        {
            if (!IsTestInProgress) return;

            GetGameRules();
            TeleportAllGameEntities();

            FindConvar();
            ReadConvar();
            WriteConvar();

            for (int i = 0; i < 64; i++)
            {
                var client = _sharedSystem.GetClientManager().GetGameClient(new PlayerSlot((byte)i));
                if (client != null && client.IsValid)
                {
                    var controller = client.GetPlayerController();
                    if (controller != null && controller.IsValid() && controller.ConnectedState == PlayerConnectedState.PlayerConnected)
                    {
                        ReplicateConvarToClient(client);
                    }
                }
            }

            FireGameEventsToPlayer();

            SendNetMessages();
        }, null);

        return true;
    }

    public void Shutdown()
    {
    }

    private HookReturnValue<NetworkReceiver> OnSendNetMessage(IPostEventAbstractHookParams param, HookReturnValue<NetworkReceiver> previousResult)
    {
        if (!IsTestInProgress) return default;
        CMsgSosStartSoundEventHandler(param);
        return default;
    }

    public void OnEntitySpawned(IBaseEntity entity)
    {
        if (IsTestInProgress)
        {
            DespawnEntity(entity);
        }
        else allEntities.Add(entity);
    }

    public void OnEntityDeleted(IBaseEntity entity)
    {
        allEntities.Remove(entity);
    }

    public void FireGameEvent(IGameEvent @event)
    {
    }

    private ECommandAction OnSaveProfiler(IGameClient? client, StringCommand command)
    {
        var json = profilerService.GenerateJSONPerformance("");
        File.WriteAllText("profiler_output.json", json);
        Console.WriteLine("Profiler data saved to profiler_output.json");
        return ECommandAction.Stopped;
    }

    private ECommandAction OnPrepareTest(IGameClient? client, StringCommand command)
    {
        var cvar = _sharedSystem.GetConVarManager().FindConVar("bot_quota");
        cvar?.Set(BotQuota);

        for (int i = 0; i < AddBots; i++)
        {
            _sharedSystem.GetClientManager().GetGameClient(new PlayerSlot(0))!.Command("bot_add");
        }
        return ECommandAction.Stopped;
    }
    private ECommandAction OnStartTest(IGameClient? client, StringCommand command)
    {
        StartMemory = GC.GetTotalMemory(true) / (1024.0f * 1024.0f);
        IsTestInProgress = true;

        CreateEntities();
        SpawnEntities();

        SchemaWriteEntities();
        SchemaReadEntities();
        VirtualCallEntities();

        return ECommandAction.Stopped;
    }

    private ECommandAction OnStopTest(IGameClient? client, StringCommand command)
    {
        IsTestInProgress = false;

        EndMemory = GC.GetTotalMemory(false) / (1024.0f * 1024.0f);
        GC.Collect();
        float MemoryAfterGC = GC.GetTotalMemory(false) / (1024.0f * 1024.0f);

        Console.WriteLine("=== Profiler Test Memory Usage ===");
        Console.WriteLine($"Memory Before Test: {StartMemory} MB");
        Console.WriteLine($"Memory After Test: {EndMemory} MB");
        Console.WriteLine($"Memory After GC: {MemoryAfterGC} MB");

        return ECommandAction.Stopped;
    }

    int IEventListener.ListenerVersion => IEventListener.ApiVersion;
    int IEventListener.ListenerPriority => 0;
}