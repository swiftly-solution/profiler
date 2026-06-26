using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using s2sdk;
using static s2sdk.s2sdk;

namespace PlugifyProfiler;

public unsafe partial class PlugifyProfiler
{
    public List<int> Entities = new();

    public void CreateEntities()
    {
        profilerService.StartRecording($"Create {MaxEntities} entities");
        for (int i = 0; i < MaxEntities; i++)
        {
            Entities.Add(CreateEntityByName("point_worldtext")!);
        }
        profilerService.StopRecording($"Create {MaxEntities} entities");
    }

    public void SpawnEntities()
    {
        profilerService.StartRecording($"Spawn {Entities.Count} entities");
        foreach (var entity in Entities)
        {
            DispatchSpawn(entity);
        }
        profilerService.StopRecording($"Spawn {Entities.Count} entities");
    }

    public void SchemaWriteEntities()
    {
        profilerService.StartRecording($"Schema Write + Update ({Entities.Count} entities)");
        int index = 0;
        foreach (var entity in Entities)
        {
            var text = $"Performance Test Entity #{index}{Random.Shared.NextInt64()}";
            SetEntSchemaString(entity, "CPointWorldText", "m_messageText", text, true, 0);
            var color = Color.FromArgb(255, 255, 0, 0).ToRgba();
            SetEntSchema(entity, "CPointWorldText", "m_Color", color, true, 0);
            index++;
        }
        profilerService.StopRecording($"Schema Write + Update ({Entities.Count} entities)");
    }

    public void SchemaReadEntities()
    {
        profilerService.StartRecording($"Schema Read ({Entities.Count} entities)");
        foreach (var entity in Entities)
        {
            var message = GetEntSchemaString(entity, "CPointWorldText", "m_messageText", 0);
            var color = ColorExtensions.FromRgba((int)GetEntSchema(entity, "CPointWorldText", "m_Color", 0));
            var enabled = GetEntSchema(entity, "CPointWorldText", "m_bEnabled", 0);
            var testColor = Color.FromArgb(255, Math.Clamp(color.R * 2, 0, 255), Math.Clamp(color.G * 2, 0, 255), Math.Clamp(color.B * 2, 0, 255));
        }
        profilerService.StopRecording($"Schema Read ({Entities.Count} entities)");
    }

    public void VirtualCallEntities()
    {
        profilerService.StartRecording($"Virtual Calls (teleport {Entities.Count} entities)");
        int index = 0;
        foreach (var entity in Entities)
        {
            TeleportEntity(entity, new Vector3(0, index * 10, 0), Vector3.Zero, Vector3.Zero);
            index++;
        }
        profilerService.StopRecording($"Virtual Calls (teleport {Entities.Count} entities)");
    }

    public void GetGameRules()
    {
        profilerService.StartRecording("Get Game Rules");

        var gameRules = s2sdk.s2sdk.GetGameRules();

        profilerService.StopRecording("Get Game Rules");
    }

    public void DespawnEntity(int entity)
    {
        profilerService.StartRecording($"Despawn entity (1 entity)");
        RemoveEntity(entity);
        profilerService.StopRecording($"Despawn entity (1 entity)");
    }

    public void TeleportAllGameEntities()
    {
        var i = GetFirstActiveEntity();
        var convertedEntities = new List<int>();
        for (; i != -1; i = GetNextActiveEntity(i))
        {
            convertedEntities.Add(i);
        }

        profilerService.StartRecording("Teleport All Game Entities");

        foreach (var entity in convertedEntities)
        {
            if (GetEntityClassname(entity) != "cs_player_controller")
            {
                TeleportEntity(entity, new Vector3(Random.Shared.Next(-1000, 1000), Random.Shared.Next(-1000, 1000), Random.Shared.Next(0, 500)), Vector3.Zero, Vector3.Zero);
            }
        }

        profilerService.StopRecording("Teleport All Game Entities");
    }
}

public static class ColorExtensions
{
    public static int ToRgba(this Color c)
    {
        return (c.A << 24) |
               (c.R << 16) |
               (c.G << 8)  |
               c.B;
    }
    
    public static Color FromRgba(int v)
    {
        byte a = (byte)((v >> 24) & 0xFF);
        byte r = (byte)((v >> 16) & 0xFF);
        byte g = (byte)((v >> 8)  & 0xFF);
        byte b = (byte)(v & 0xFF);
        return Color.FromArgb(a, r, g, b);
    }
}