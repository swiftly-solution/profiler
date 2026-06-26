using s2sdk;

namespace PlugifyProfiler;

public partial class PlugifyProfiler
{
    public static int NetMessageMultiplier = 1024;

    public void SendNetMessages()
    {
        profilerService.StartRecording($"Send NetMessage to All Players");

        var message = new UserMessage(120);
        message.SetFloat("frequency", 1.0f);
        message.AddAllPlayers();
        message.Send();

        profilerService.StopRecording($"Send NetMessage to All Players");
    }

    internal void CMsgSosStartSoundEventHandler(UserMessage msg)
    {
        profilerService.StartRecording($"CMsgSosStartSoundEvent Add All Recipients (Server sends NetMessage, {NetMessageMultiplier} times)");

        for (int i = 0; i < NetMessageMultiplier; i++)
            msg.AddAllPlayers();

        profilerService.StopRecording($"CMsgSosStartSoundEvent Add All Recipients (Server sends NetMessage, {NetMessageMultiplier} times)");
    }

    // public void CCLCMsg_MoveHandler(CCLCMsg_Move msg, int playerid)
    // {
    //     Core.Profiler.StartRecording($"CCLCMsg_Move Simulate Data (Server receives NetMessage, {NetMessageMultiplier} times)");

    //     for (int i = 0; i < NetMessageMultiplier; i++)
    //     {
    //         var data = BitConverter.ToString(msg.Data); // convert bytes to string
    //         _ = data.Length * playerid;
    //     }

    //     Core.Profiler.StopRecording($"CCLCMsg_Move Simulate Data (Server receives NetMessage, {NetMessageMultiplier} times)");
    // }

    // this is disabled due to not being implemented yet in CounterStrikeSharp
}