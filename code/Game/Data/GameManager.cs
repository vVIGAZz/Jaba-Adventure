using Sandbox;
using System.Threading.Tasks;

public sealed class GameManager : Component
{
	[Property] public GameObject SpawnManager;
    [Property] public GameObject Player;
    protected override void OnStart()
    {
        SpawnManager.Enabled = false;
        Player.Enabled = false;
        _ = GameDelay();
    }


    async Task GameDelay()
    {
        while (true)
        {
            await Task.DelaySeconds(3);
            SpawnManager.Enabled = true;
            Player.Enabled = true;
            break;
        }
    }
	public void StopSpawn()
	{
		SpawnManager.Enabled = false;
	}
    protected override void OnEnabled()
    {
		EventManager.OnPlayerDie += StopSpawn;
    }
    protected override void OnDisabled()
    {
        EventManager.OnPlayerDie -= StopSpawn;
    }
}
