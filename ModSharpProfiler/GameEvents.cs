using System.Runtime.CompilerServices;
using Sharp.Shared.GameEntities;
using Sharp.Shared.Objects;

namespace ModSharpProfiler;

public partial class ModSharpProfiler
{
    public static int GameEventMultiplier = 1024;

    public void FireGameEventsToPlayer()
    {
        profilerService.StartRecording($"Fire Game Event to Players");

        if (_gameEventManager.CreateEvent("show_survival_respawn_status", false) is { } e)
        {
            e.SetString("loc_token", "some message");
            e.SetUInt64("duration", 1);
            e.FireToClient(0);
        }

        profilerService.StopRecording($"Fire Game Event to Players");
    }
}