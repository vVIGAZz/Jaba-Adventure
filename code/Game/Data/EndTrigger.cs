using Sandbox;

public sealed class EndTrigger : Component, Component.ITriggerListener
{
	public void OnTriggerEnter(Collider other)
	{
		if (other != null)
		{
			other.GameObject.Destroy();
		}
	}
}
