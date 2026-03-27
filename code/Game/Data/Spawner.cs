using Sandbox;

public sealed class Spawner : Component
{
	[Property] List<GameObject> Entity {  get; set; }
	private float _timer;
	protected override void OnUpdate()
	{
		_timer -= Time.Delta;
		if (_timer <= 0)
		{
            foreach (var entity in Entity)
            {
                if (entity.Tags.Has("coin"))
                {
                    _timer = 6f;
                    entity.Clone(WorldPosition);
                }
                if (entity.Tags.Has("traps"))
                {
                    _timer = 3;
                    Entity[Game.Random.Next(0, Entity.Count)].Clone(WorldPosition);
                }
            }
        }

	}
}
