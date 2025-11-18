using Sharp.Shared.HookParams;
using Sharp.Shared.Units;

namespace ModSharpProfiler;

public partial class ModSharpProfiler
{
    public static int NetMessageMultiplier = 1024;

    public void SendNetMessages()
    {
        profilerService.StartRecording($"Send NetMessage to All Players");

        var shakeMessage = new CUserMessageShake
        {
            Frequency = 1.0f,
        };

        _modSharp.SendNetMessage(default, shakeMessage);

        profilerService.StopRecording($"Send NetMessage to All Players");
    }

    public void CMsgSosStartSoundEventHandler(IPostEventAbstractHookParams param)
    {
        profilerService.StartRecording($"CMsgSosStartSoundEvent Add All Recipients (Server sends NetMessage, {NetMessageMultiplier} times)");

        for (int i = 0; i < NetMessageMultiplier; i++)
        {
            for (int j = 0; j < 64; j++)
            {
                var playerSlot = new PlayerSlot((byte)j);
                if (!param.Receivers.HasClient(playerSlot))
                    param.Receivers.Append(playerSlot);
            }
        }

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

    // this is disabled due to not being implemented yet in ModSharp
}