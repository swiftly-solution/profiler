using SwiftlyS2.Shared.GameEventDefinitions;

namespace Profiler;

public partial class Profiler
{
    public void FireGameEventsToPlayer()
    {
        Core.Profiler.StartRecording($"Fire Game Event to Players");

        Core.GameEvent.FireToPlayer<EventShowSurvivalRespawnStatus>(0, (e) =>
        {
            e.LocToken = "some message";
            e.Duration = 1;
        });

        Core.Profiler.StopRecording($"Fire Game Event to Players");
    }
}