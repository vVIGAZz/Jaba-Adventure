using Sandbox;
public sealed class SpawnManager : Component
{
	private float seconds;
	[Property] float Timer { get; set; }
	[Property] public bool GameIsStart;
	[Property] List<GameObject> point;
	protected override void OnStart()
	{
		GameIsStart = true;

    }
    protected override void OnUpdate()
    {
        if (GameIsStart)
		{
			seconds -= Time.Delta;
			if (seconds <= 0)
			{
                var spawn = point[Game.Random.Next(point.Count)];
                spawn.GetComponent<Spawner>().Spawn();
				seconds = Timer;
            }
		}
    }
}
