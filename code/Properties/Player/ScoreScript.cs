using Sandbox;

public sealed class ScoreScript : Component, Component.ITriggerListener
{
	[Property] public GameObject coin;
	[Property] public GameObject player;
	[Property] public GameObject wood;
	[Property] public SceneFile died;
	public float score = 0f;
	public void OnTriggerEnter(Collider other)
	{
		if ( other.Tags.Has( "coin" ) )
		{
			coin.Destroy();
			score++;
		}
		if ( other.Tags.Has("enemy") )
		{
			player.Destroy();
			score = 0;
			Scene.Load(died);
		}
	}
}
