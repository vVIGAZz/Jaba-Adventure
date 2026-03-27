using Sandbox;
using System.Threading.Tasks;

public sealed class SpawnManager : Component
{
	[Property] int Seconds { get; set; }
	[Property] List<GameObject> point;
	protected override void OnStart()
	{
		_ = Timer();
	}

	async Task Timer()
	{
		while (true)
		{
			await Task.DelayRealtimeSeconds(Seconds);
			var spawn = point[Game.Random.Next(point.Count)];
			spawn.GetComponent<Spawner>().Spawn();
		}
	}
}
