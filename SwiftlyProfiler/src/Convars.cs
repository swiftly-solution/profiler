using SwiftlyS2.Shared.Convars;

namespace Profiler;

public partial class Profiler
{
    public IConVar<float>? PlayerSpeedHasHostage;
    public static int ConvarActionMultiplier = 1024;

    public void FindConvar()
    {
        profilerService.StartRecording("Find ConVar");
        PlayerSpeedHasHostage = Core.ConVar.Find<float>("sv_cs_player_speed_has_hostage");
        profilerService.StopRecording("Find ConVar");
    }

    public void ReadConvar()
    {
        profilerService.StartRecording($"Read ConVar ({ConvarActionMultiplier} times)");
        for (int i = 0; i < ConvarActionMultiplier; i++)
        {
            var value = PlayerSpeedHasHostage?.Value;
        }
        profilerService.StopRecording($"Read ConVar ({ConvarActionMultiplier} times)");
    }

    public void WriteConvar()
    {
        profilerService.StartRecording($"Write ConVar ({ConvarActionMultiplier} times)");

        for (int i = 0; i < ConvarActionMultiplier; i++)
        {
            PlayerSpeedHasHostage!.Value = 0.5f + (i % 10) * 0.1f;
        }

        profilerService.StopRecording($"Write ConVar ({ConvarActionMultiplier} times)");
    }

    public void ReplicateConvarToClient(int playerid)
    {
        profilerService.StartRecording($"Replicate ConVar to Client ({ConvarActionMultiplier} times)");

        for (int i = 0; i < ConvarActionMultiplier; i++)
            PlayerSpeedHasHostage?.ReplicateToClient(playerid, (float)Random.Shared.NextDouble());

        profilerService.StopRecording($"Replicate ConVar to Client ({ConvarActionMultiplier} times)");
    }
}