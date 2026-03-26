using Sandbox;

public sealed class PropsMovement : Component
{
	[Property] Vector3 WishDir { get; set; }
	[Property] float Speed { get; set; }
	protected override void OnFixedUpdate()
	{
		WishDir += Vector3.Left * Speed;
		WorldPosition += WishDir;
	}
}
