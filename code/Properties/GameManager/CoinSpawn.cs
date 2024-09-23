using Sandbox;

public sealed class CoinSpawn : Component
{
	[Property] public GameObject coin;
	[Property] GameObject spawnPoint;
	public float timer = 220f;
	protected override void OnUpdate()
	{
		timer--;
		if ( timer == 0f )
		{
			coin.Clone( spawnPoint.Transform.Position, spawnPoint.Transform.Rotation );
			timer = 220f;

		}
	}
}
