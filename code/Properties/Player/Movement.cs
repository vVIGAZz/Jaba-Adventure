using Sandbox;
using SpriteTools;

public sealed class Movement : Component
{
	[Property] public Rigidbody rb;
	[Property] public SpriteComponent sprite;
	public float jumpHeight = 550f;
	public bool ground = true;

	protected override void OnStart()
	{
		rb.Components.Get<Rigidbody>();
	}
	protected override void OnUpdate() 
	{
		if ( rb.Transform.Position.z < 85)
		{
			sprite.PlayAnimation("Idle");
			ground = true;
		}
		else if( rb.Transform.Position.z > 65 )
		{
			sprite.PlayAnimation( "Jump" );
			ground = false;
		}
		if (Input.Pressed("Jump") && ground == true)
		{
			rb.Velocity += Vector3.Up * jumpHeight;
		}
	}

}
