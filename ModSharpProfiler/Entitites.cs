using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sharp.Shared.GameEntities;
using Sharp.Shared.Types;

namespace ModSharpProfiler;

public partial class ModSharpProfiler
{
    public List<IBaseEntity> Entities = new();

    public void CreateEntities()
    {
        profilerService.StartRecording($"Create {MaxEntities} entities");
        for (int i = 0; i < MaxEntities; i++)
        {
            Entities.Add(_entityManager.CreateEntityByName("point_worldtext")!);
        }
        profilerService.StopRecording($"Create {MaxEntities} entities");
    }

    public void SpawnEntities()
    {
        profilerService.StartRecording($"Spawn {Entities.Count} entities");
        foreach (var entity in Entities)
        {
            entity.DispatchSpawn();
        }
        profilerService.StopRecording($"Spawn {Entities.Count} entities");
    }

    public void SchemaWriteEntities()
    {
        profilerService.StartRecording($"Schema Write + Update ({Entities.Count} entities)");
        int index = 0;
        foreach (var entity in Entities)
        {
            var worldTextEntity = entity.As<IWorldText>();
            worldTextEntity.Message = $"Performance Test Entity #{index}{Random.Shared.NextInt64()}";
            worldTextEntity.Color = new Color32(255, 0, 0, 0);
            index++;
        }
        profilerService.StopRecording($"Schema Write + Update ({Entities.Count} entities)");
    }

    public void GetGameRules()
    {
        profilerService.StartRecording("Get Game Rules");

        var gameRules = _modSharp.GetGameRules();

        profilerService.StopRecording("Get Game Rules");
    }

    public void SchemaReadEntities()
    {
        profilerService.StartRecording($"Schema Read ({Entities.Count} entities)");
        foreach (var entity in Entities)
        {
            var worldTextEntity = entity.As<IWorldText>();
            var message = worldTextEntity.Message;
            var color = worldTextEntity.Color;
            var enabled = worldTextEntity.Enabled;
            var testColor = new Color32((byte)Math.Clamp(worldTextEntity.Color.R * 2, 0, 255), (byte)Math.Clamp(worldTextEntity.Color.G * 2, 0, 255), (byte)Math.Clamp(worldTextEntity.Color.B * 2, 0, 255), 0);
        }
        profilerService.StopRecording($"Schema Read ({Entities.Count} entities)");
    }

    public void VirtualCallEntities()
    {
        profilerService.StartRecording($"Virtual Calls (teleport {Entities.Count} entities)");
        int index = 0;
        foreach (var entity in Entities)
        {
            entity.Teleport(new Vector(0, index * 10, 0), null, null);
            index++;
        }
        profilerService.StopRecording($"Virtual Calls (teleport {Entities.Count} entities)");
    }

    public void DespawnEntity(IBaseEntity entity)
    {
        profilerService.StartRecording($"Despawn entity (1 entity)");
        entity.Kill();
        profilerService.StopRecording($"Despawn entity (1 entity)");
    }

    public void TeleportAllGameEntities()
    {
        profilerService.StartRecording("Teleport All Game Entities");

        foreach (var entity in allEntities)
        {
            if (entity.Classname != "cs_player_controller")
            {
                entity.Teleport(new(Random.Shared.Next(-1000, 1000), Random.Shared.Next(-1000, 1000), Random.Shared.Next(0, 500)), null, null);
            }
        }

        profilerService.StopRecording("Teleport All Game Entities");
    }
}