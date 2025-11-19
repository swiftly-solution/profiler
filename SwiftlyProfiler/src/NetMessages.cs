using SwiftlyS2.Shared.ProtobufDefinitions;

namespace Profiler;

public partial class Profiler
{
    public static int NetMessageMultiplier = 1024;

    public void SendNetMessages()
    {
        profilerService.StartRecording($"Send NetMessage to All Players");

        var netmsg = Core.NetMessage.Create<CUserMessageShake>();
        netmsg.Frequency = 1f;
        netmsg.SendToAllPlayers();

        profilerService.StopRecording($"Send NetMessage to All Players");
    }

    public void CMsgSosStartSoundEventHandler(CMsgSosStartSoundEvent msg)
    {
        profilerService.StartRecording($"CMsgSosStartSoundEvent Add All Recipients (Server sends NetMessage, {NetMessageMultiplier} times)");

        for (int i = 0; i < NetMessageMultiplier; i++)
            msg.Recipients.AddAllPlayers();

        profilerService.StopRecording($"CMsgSosStartSoundEvent Add All Recipients (Server sends NetMessage, {NetMessageMultiplier} times)");
    }

    public void CCLCMsg_MoveHandler(CCLCMsg_Move msg, int playerid)
    {
        profilerService.StartRecording($"CCLCMsg_Move Simulate Data (Server receives NetMessage, {NetMessageMultiplier} times)");

        for (int i = 0; i < NetMessageMultiplier; i++)
        {
            var data = BitConverter.ToString(msg.Data); // convert bytes to string
            _ = data.Length * playerid;
        }

        profilerService.StopRecording($"CCLCMsg_Move Simulate Data (Server receives NetMessage, {NetMessageMultiplier} times)");
    }
}