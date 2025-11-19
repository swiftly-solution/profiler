using SwiftlyS2.Shared.GameEventDefinitions;

namespace Profiler;

public partial class Profiler
{
    public void FireGameEventsToPlayer()
    {
        profilerService.StartRecording($"Fire Game Event to Players");

        Core.GameEvent.FireToPlayer<EventShowSurvivalRespawnStatus>(0, (e) =>
        {
            e.LocToken = "some message";
            e.Duration = 1;
        });

        profilerService.StopRecording($"Fire Game Event to Players");
    }
}