using Sandbox;

public sealed class Rotate : Component
{
	protected override void OnUpdate()
	{
		WorldRotation *= Rotation.FromYaw(1);
	}
}
