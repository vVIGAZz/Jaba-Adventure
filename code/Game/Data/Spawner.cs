using Sandbox;

public sealed class Spawner : Component
{
	[Property] List<GameObject> Entity {  get; set; }
	private float _timer;
    public void Spawn()
    {
        Entity[Game.Random.Next(Entity.Count)].Clone(WorldPosition);
    }
}
