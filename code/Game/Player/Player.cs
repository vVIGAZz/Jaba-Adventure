using Sandbox;

public sealed class Player : Component, Component.ITriggerListener
{
	[Property] int Score { get; set; }

	protected override void OnUpdate()
	{

	}

	private void Died()
	{
		//Scene.GetComponent<Movement>().Enabled = false;

	}
	public void OnTriggerEnter(Collider other)
	{
		if (other.Tags.Has("traps"))
		{
			Died();
		}
		if (other.Tags.Has("coin")){
			Score++;
		}
	}
}
