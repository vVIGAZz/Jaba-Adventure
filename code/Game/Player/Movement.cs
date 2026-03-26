using Sandbox;

public sealed class Movement : Component
{
    [Property] public CharacterController Controller;
    [Property] public SkinnedModelRenderer animation;
    public float speed = 110f;
    private Vector3 _gravity = new Vector3(0, 0, 800);

    protected override void OnStart()
    {
        Log.Info($"Controller: {Controller}, animation: {animation}");
    }
    protected override void OnUpdate()
    {
        animation.Parameters.Set("move_x", speed);
    }
    protected override void OnFixedUpdate()
    {
        if (Controller.IsOnGround && Input.Pressed("jump"))
        {
            Controller.Punch(Vector3.Up * 469f);
            animation.Parameters.Set("b_jump", true);
        }
        if (Controller.IsOnGround)
        {
            animation.Parameters.Set("b_grounded", true);

        }
        else
        {
            Controller.Velocity -= _gravity * Time.Delta;
            animation.Parameters.Set("b_grounded", false);
        }
        Controller.Move();
    }
}
