using System;
using s2sdk;
using static s2sdk.s2sdk;

namespace PlugifyProfiler;

public partial class PlugifyProfiler
{
    internal ConVar? PlayerSpeedHasHostage;
    public static int ConvarActionMultiplier = 1024;

    public void FindConvar()
    {
        profilerService.StartRecording("Find ConVar");
        PlayerSpeedHasHostage = ConVar.Find("sv_cs_player_speed_has_hostage");
        profilerService.StopRecording("Find ConVar");
    }

    public void ReadConvar()
    {
        profilerService.StartRecording($"Read ConVar ({ConvarActionMultiplier} times)");
        for (int i = 0; i < ConvarActionMultiplier; i++)
        {
            var value = PlayerSpeedHasHostage?.GetValue();
        }
        profilerService.StopRecording($"Read ConVar ({ConvarActionMultiplier} times)");
    }

    public void WriteConvar()
    {
        profilerService.StartRecording($"Write ConVar ({ConvarActionMultiplier} times)");

        for (int i = 0; i < ConvarActionMultiplier; i++)
        {
            PlayerSpeedHasHostage!.SetFloat(0.5f + (i % 10) * 0.1f, false, false);
        }

        profilerService.StopRecording($"Write ConVar ({ConvarActionMultiplier} times)");
    }

    public void ReplicateConvarToClient(int playerid)
    {
        profilerService.StartRecording($"Replicate ConVar to Client ({ConvarActionMultiplier} times)");

        for (int i = 0; i < ConvarActionMultiplier; i++)
        {
            PlayerSpeedHasHostage!.SendValue(playerid, Random.Shared.NextDouble().ToString());
        }

        profilerService.StopRecording($"Replicate ConVar to Client ({ConvarActionMultiplier} times)");

    }
}