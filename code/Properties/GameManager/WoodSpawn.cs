using Sandbox;

public sealed class WoodSpawn : Component
{
	[Property] public ScoreScript score;
	[Property] public GameObject wood1;
	[Property] public GameObject wood2;
	[Property] GameObject spawnPoint;
	public float timer = 220f;
	protected override void OnUpdate()
	{
		var random = Game.Random.Int( 0, 1 );
		timer--;
		if ( score.score <= 5 && timer == 0f && random == 1)
		{
			wood1.Clone( spawnPoint.Transform.Position, spawnPoint.Transform.Rotation );
			timer = 220f;
		}
		else if ( score.score <= 5 && timer == 0f && random == 0 )
		{
			wood2.Clone( spawnPoint.Transform.Position, spawnPoint.Transform.Rotation );
			timer = 220f;
		}
		if ( score.score <= 15 && timer == 0f && random == 1 )
		{
			wood1.Clone( spawnPoint.Transform.Position, spawnPoint.Transform.Rotation );
			timer = 100f;
		}
		else if ( score.score <= 15 && timer == 0f && random == 0 )
		{
			wood2.Clone( spawnPoint.Transform.Position, spawnPoint.Transform.Rotation );
			timer = 100f;
		}
		if ( score.score <= 25 && timer == 0f && random == 1 )
		{
			wood1.Clone( spawnPoint.Transform.Position, spawnPoint.Transform.Rotation );
			timer = 90f;
		}
		else if ( score.score <= 25 && timer == 0f && random == 0 )
		{
			wood2.Clone( spawnPoint.Transform.Position, spawnPoint.Transform.Rotation );
			timer = 90f;
		}
		if ( score.score <= 35 && timer == 0f && random == 1 )
		{
			wood1.Clone( spawnPoint.Transform.Position, spawnPoint.Transform.Rotation );
			timer = 80f;
		}
		else if ( score.score <= 35 && timer == 0f && random == 0 )
		{
			wood2.Clone( spawnPoint.Transform.Position, spawnPoint.Transform.Rotation );
			timer = 80f;
		}
		if ( score.score <= 75 && timer == 0f && random == 1 )
		{
			wood1.Clone( spawnPoint.Transform.Position, spawnPoint.Transform.Rotation );
			timer = 70f;
		}
		else if ( score.score <= 75 && timer == 0f && random == 0 )
		{
			wood2.Clone( spawnPoint.Transform.Position, spawnPoint.Transform.Rotation );
			timer = 70f;
		}
		if ( score.score <= 999 && timer == 0f && random == 1 )
		{
			wood1.Clone( spawnPoint.Transform.Position, spawnPoint.Transform.Rotation );
			timer = 60f;
		}
		else if ( score.score <= 999 && timer == 0f && random == 0 )
		{
			wood2.Clone( spawnPoint.Transform.Position, spawnPoint.Transform.Rotation );
			timer = 60f;
		}
	}
}
