using Sandbox;

public sealed class CoinMove : Component, Component.ITriggerListener
{
	[Property] ScoreScript score;
	[Property] GameObject coin;

	public void OnTriggerEnter(Collider other)
	{
		if (other.Tags.Has("Player")) 
		{
			coin.Destroy();
		}
	}
	protected override void OnUpdate()
	{
		if ( Transform.Position.y >= 630f )
		{
			coin.Destroy();
		}
		if ( score.score <= 5 )
		{
			Transform.Position += new Vector3( 0, 2, 0 );
		}
		else if (score.score <= 15) 
		{
			Transform.Position += new Vector3( 0, 3, 0 );
		}
		else if ( score.score <= 999 )
		{
			Transform.Position += new Vector3( 0, 4, 0 );
		}
	}
}
