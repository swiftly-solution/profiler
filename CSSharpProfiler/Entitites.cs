using System.Drawing;
using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;

namespace CSSharpProfiler;

public partial class CSSharpProfiler
{
    public List<CBaseEntity> Entities = new();

    public void CreateEntities()
    {
        profilerService.StartRecording($"Create {MaxEntities} entities");
        for (int i = 0; i < MaxEntities; i++)
        {
            Entities.Add(Utilities.CreateEntityByName<CPointWorldText>("point_worldtext")!);
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
            var textEntity = entity.As<CPointWorldText>();
            textEntity!.MessageText = $"Performance Test Entity #{index}{Random.Shared.NextInt64()}";
            Utilities.SetStateChanged(textEntity, "CPointWorldText", "m_messageText");
            textEntity!.Color = Color.FromArgb(255, 255, 0, 0);
            Utilities.SetStateChanged(textEntity, "CPointWorldText", "m_Color");
            index++;
        }
        profilerService.StopRecording($"Schema Write + Update ({Entities.Count} entities)");
    }

    public void SchemaReadEntities()
    {
        profilerService.StartRecording($"Schema Read ({Entities.Count} entities)");
        foreach (var entity in Entities)
        {
            var textEntity = entity.As<CPointWorldText>();
            var message = textEntity!.MessageText;
            var color = textEntity!.Color;
            var enabled = textEntity!.Enabled;
            var testColor = Color.FromArgb(255, Math.Clamp(textEntity!.Color.R * 2, 0, 255), Math.Clamp(textEntity!.Color.G * 2, 0, 255), Math.Clamp(textEntity!.Color.B * 2, 0, 255));
        }
        profilerService.StopRecording($"Schema Read ({Entities.Count} entities)");
    }

    public void VirtualCallEntities()
    {
        profilerService.StartRecording($"Virtual Calls (teleport {Entities.Count} entities)");
        int index = 0;
        foreach (var entity in Entities)
        {
            var textEntity = entity.As<CPointWorldText>();
            textEntity!.Teleport(new CounterStrikeSharp.API.Modules.Utils.Vector(0, index * 10, 0), null, null);
            index++;
        }
        profilerService.StopRecording($"Virtual Calls (teleport {Entities.Count} entities)");
    }

    public void GetGameRules()
    {
        profilerService.StartRecording("Get Game Rules");

        var gameRules = Utilities.FindAllEntitiesByDesignerName<CCSGameRulesProxy>("cs_gamerules").First().GameRules;

        profilerService.StopRecording("Get Game Rules");
    }

    public void DespawnEntity(CBaseEntity entity)
    {
        profilerService.StartRecording($"Despawn entity (1 entity)");
        entity.Remove();
        profilerService.StopRecording($"Despawn entity (1 entity)");
    }

    public void TeleportAllGameEntities()
    {
        var allEntities = Utilities.GetAllEntities();
        var convertedEntities = new List<CBaseEntity>();
        foreach (var entity in allEntities)
        {
            convertedEntities.Add(entity.As<CBaseEntity>());
        }

        profilerService.StartRecording("Teleport All Game Entities");

        foreach (var entity in convertedEntities)
        {
            if (entity.DesignerName != "cs_player_controller")
            {
                entity.Teleport(new CounterStrikeSharp.API.Modules.Utils.Vector(Random.Shared.Next(-1000, 1000), Random.Shared.Next(-1000, 1000), Random.Shared.Next(0, 500)), null, null);
            }
        }

        profilerService.StopRecording("Teleport All Game Entities");
    }
}