using System;
using Sharp.Shared.Objects;
using Sharp.Shared.Units;

namespace ModSharpProfiler;

public partial class ModSharpProfiler
{
    public IConVar? PlayerSpeedHasHostage;
    public static int ConvarActionMultiplier = 1024;

    public void FindConvar()
    {
        profilerService.StartRecording("Find ConVar");
        PlayerSpeedHasHostage = _sharedSystem.GetConVarManager().FindConVar("sv_cs_player_speed_has_hostage");
        profilerService.StopRecording("Find ConVar");
    }

    public void ReadConvar()
    {
        profilerService.StartRecording($"Read ConVar ({ConvarActionMultiplier} times)");
        for (int i = 0; i < ConvarActionMultiplier; i++)
        {
            var value = PlayerSpeedHasHostage?.GetFloat();
        }
        profilerService.StopRecording($"Read ConVar ({ConvarActionMultiplier} times)");
    }

    public void WriteConvar()
    {
        profilerService.StartRecording($"Write ConVar ({ConvarActionMultiplier} times)");

        for (int i = 0; i < ConvarActionMultiplier; i++)
        {
            PlayerSpeedHasHostage!.Set(0.5f + (i % 10) * 0.1f);
        }

        profilerService.StopRecording($"Write ConVar ({ConvarActionMultiplier} times)");
    }

    public void ReplicateConvarToClient(IGameClient client)
    {
        // profilerService.StartRecording($"Replicate ConVar to Client ({ConvarActionMultiplier} times)");

        // for (int i = 0; i < ConvarActionMultiplier; i++)
        //     PlayerSpeedHasHostage?.ReplicateToClient(client, Random.Shared.NextDouble().ToString());

        // for some reason i get message overflow when replicating
        // https://cdn.skuzzi.ro/OEO0XIVqC24ryFzCgf0gm1IqvuzXDCEX.png

        // profilerService.StopRecording($"Replicate ConVar to Client ({ConvarActionMultiplier} times)");
    }
}