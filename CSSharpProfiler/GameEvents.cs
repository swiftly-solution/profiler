using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;

namespace CSSharpProfiler;

public partial class CSSharpProfiler
{
    public void FireGameEventsToPlayer()
    {
        profilerService.StartRecording($"Fire Game Event to Players");

        var e = new EventShowSurvivalRespawnStatus(true)
        {
            LocToken = "some message",
            Duration = 1
        };

        e.FireEventToClient(Utilities.GetPlayerFromSlot(0)!);

        profilerService.StopRecording($"Fire Game Event to Players");
    }
}