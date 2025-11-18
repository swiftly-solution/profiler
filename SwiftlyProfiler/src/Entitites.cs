using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.SchemaDefinitions;

namespace Profiler;

public partial class Profiler
{
    public List<CBaseEntity> Entities = new();

    public void CreateEntities()
    {
        Core.Profiler.StartRecording($"Create {MaxEntities} entities");
        for (int i = 0; i < MaxEntities; i++)
        {
            Entities.Add(Core.EntitySystem.CreateEntity<CPointWorldText>());
        }
        Core.Profiler.StopRecording($"Create {MaxEntities} entities");
    }

    public void SpawnEntities()
    {
        Core.Profiler.StartRecording($"Spawn {Entities.Count} entities");
        foreach (var entity in Entities)
        {
            entity.DispatchSpawn();
        }
        Core.Profiler.StopRecording($"Spawn {Entities.Count} entities");
    }

    public void SchemaWriteEntities()
    {
        Core.Profiler.StartRecording($"Schema Write + Update ({Entities.Count} entities)");
        int index = 0;
        foreach (var entity in Entities)
        {
            var textEntity = entity.As<CPointWorldText>();
            textEntity!.MessageText = $"Performance Test Entity #{index}{Random.Shared.NextInt64()}";
            textEntity!.MessageTextUpdated();
            textEntity!.Color = new Color(255, 0, 0);
            textEntity!.ColorUpdated();
            index++;
        }
        Core.Profiler.StopRecording($"Schema Write + Update ({Entities.Count} entities)");
    }

    public void SchemaReadEntities()
    {
        Core.Profiler.StartRecording($"Schema Read ({Entities.Count} entities)");
        foreach (var entity in Entities)
        {
            var textEntity = entity.As<CPointWorldText>();
            var message = textEntity!.MessageText;
            var color = textEntity!.Color;
            var enabled = textEntity!.Enabled;
            var testColor = new Color(textEntity!.Color.R * 2, textEntity!.Color.G * 2, textEntity!.Color.A * 2);
        }
        Core.Profiler.StopRecording($"Schema Read ({Entities.Count} entities)");
    }

    public void VirtualCallEntities()
    {
        Core.Profiler.StartRecording($"Virtual Calls (teleport {Entities.Count} entities)");
        int index = 0;
        foreach (var entity in Entities)
        {
            var textEntity = entity as CPointWorldText;
            textEntity!.Teleport(new(0, index * 10, 0), null, null);
            index++;
        }
        Core.Profiler.StopRecording($"Virtual Calls (teleport {Entities.Count} entities)");
    }

    public void GetGameRules()
    {
        Core.Profiler.StartRecording("Get Game Rules");

        var gameRules = Core.EntitySystem.GetGameRules();

        Core.Profiler.StopRecording("Get Game Rules");
    }

    public void DespawnEntity(CBaseEntity entity)
    {
        Core.Profiler.StartRecording($"Despawn entity (1 entity)");
        entity.Despawn();
        Core.Profiler.StopRecording($"Despawn entity (1 entity)");
    }

    public void TeleportAllGameEntities()
    {
        var allEntities = Core.EntitySystem.GetAllEntities();

        Core.Profiler.StartRecording("Teleport All Game Entities");

        foreach (var entity in allEntities)
        {
            if (entity.DesignerName != "cs_player_controller")
            {
                var baseEntity = entity.As<CBaseEntity>();
                baseEntity!.Teleport(new(Random.Shared.Next(-1000, 1000), Random.Shared.Next(-1000, 1000), Random.Shared.Next(0, 500)), null, null);
            }
        }

        Core.Profiler.StopRecording("Teleport All Game Entities");
    }
}