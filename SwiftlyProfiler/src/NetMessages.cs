using SwiftlyS2.Shared.ProtobufDefinitions;

namespace Profiler;

public partial class Profiler
{
    public static int NetMessageMultiplier = 1024;

    public void SendNetMessages()
    {
        Core.Profiler.StartRecording($"Send NetMessage to All Players ({NetMessageMultiplier} times)");

        Core.NetMessage.Send<CUserMessageShake>(um =>
        {
            um.Frequency = 1f;
            um.Recipients.AddAllPlayers();
        });

        Core.Profiler.StopRecording($"Send NetMessage to All Players ({NetMessageMultiplier} times)");
    }

    public void CMsgSosStartSoundEventHandler(CMsgSosStartSoundEvent msg)
    {
        Core.Profiler.StartRecording($"CMsgSosStartSoundEvent Add All Recipients (Server sends NetMessage, {NetMessageMultiplier} times)");

        for (int i = 0; i < NetMessageMultiplier; i++)
            msg.Recipients.AddAllPlayers();

        Core.Profiler.StopRecording($"CMsgSosStartSoundEvent Add All Recipients (Server sends NetMessage, {NetMessageMultiplier} times)");
    }

    public void CCLCMsg_MoveHandler(CCLCMsg_Move msg, int playerid)
    {
        Core.Profiler.StartRecording($"CCLCMsg_Move Simulate Data (Server receives NetMessage, {NetMessageMultiplier} times)");

        for (int i = 0; i < NetMessageMultiplier; i++)
        {
            var data = BitConverter.ToString(msg.Data); // convert bytes to string
            _ = data.Length * playerid;
        }

        Core.Profiler.StopRecording($"CCLCMsg_Move Simulate Data (Server receives NetMessage, {NetMessageMultiplier} times)");
    }
}