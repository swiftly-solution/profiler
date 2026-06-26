using s2sdk;

namespace PlugifyProfiler;

public partial class PlugifyProfiler
{
    public void FireGameEventsToPlayer()
    {
        profilerService.StartRecording($"Fire Game Event to Players");

        var e = new EventInfo("show_survival_respawn_status", true);

        e.SetString("loc_token", "some message");
        e.SetInt("duration", 1);
        e.SetInt("userid", 0);
        
        e.FireToClient(0);
        
        profilerService.StopRecording($"Fire Game Event to Players");
    }
}