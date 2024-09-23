using Sandbox;

public sealed class WoodMove : Component
{
	[Property] ScoreScript score;
	[Property] GameObject wood;
	protected override void OnUpdate()
	{
		if ( Transform.Position.y >= 630f )
		{
			wood.Destroy();
		}
		if ( score.score <= 5 )
		{
			Transform.Position += new Vector3( 0, 4, 0 );
		}
		else if ( score.score <= 15 )
		{
			Transform.Position += new Vector3( 0, 5, 0 );
		}
		else if ( score.score <= 25 )
		{
			Transform.Position += new Vector3( 0, 6, 0 );
		}
		else if ( score.score <= 35 )
		{
			Transform.Position += new Vector3( 0, 7, 0 );
		}
		else if ( score.score <= 45 )
		{
			Transform.Position += new Vector3( 0, 8, 0 );
		}
		else if ( score.score <= 55 )
		{
			Transform.Position += new Vector3( 0, 9, 0 );
		}
		else if ( score.score <= 999 )
		{
			Transform.Position += new Vector3( 0, 10, 0 );
		}
	}
}
