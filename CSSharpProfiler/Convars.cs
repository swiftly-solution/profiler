using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Cvars;

namespace CSSharpProfiler;

public partial class CSSharpProfiler
{
    public ConVar? PlayerSpeedHasHostage;
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
            var value = PlayerSpeedHasHostage?.StringValue;
        }
        profilerService.StopRecording($"Read ConVar ({ConvarActionMultiplier} times)");
    }

    public void WriteConvar()
    {
        profilerService.StartRecording($"Write ConVar ({ConvarActionMultiplier} times)");

        for (int i = 0; i < ConvarActionMultiplier; i++)
        {
            PlayerSpeedHasHostage!.SetValue(0.5f + (i % 10) * 0.1f);
        }

        profilerService.StopRecording($"Write ConVar ({ConvarActionMultiplier} times)");
    }

    public void ReplicateConvarToClient(int playerid)
    {
        profilerService.StartRecording($"Replicate ConVar to Client ({ConvarActionMultiplier} times)");

        // var controller = Utilities.GetPlayerFromSlot(playerid)!;
        // for (int i = 0; i < ConvarActionMultiplier; i++)
        // controller.ReplicateConVar("sv_cs_player_speed_has_hostage", Random.Shared.NextDouble().ToString());

        profilerService.StopRecording($"Replicate ConVar to Client ({ConvarActionMultiplier} times)");

    }
}