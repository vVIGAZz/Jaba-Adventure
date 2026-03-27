using Sandbox;

public sealed class Player : Component, Component.ITriggerListener
{
	[Property] public int Score { get; set; }
	[Property] public Movement playerMovement;
	[Property] public ModelPhysics ragdoll;

	private void Died()
	{
		playerMovement.Enabled = false;
		ragdoll.Enabled = true;

	}
	public void OnTriggerEnter(Collider other)
	{
		if (other.Tags.Has("traps"))
		{
			Died();
		}
		if (other.Tags.Has("coin")){
			Score++;
			other.GameObject.Destroy();
		}
	}
}
