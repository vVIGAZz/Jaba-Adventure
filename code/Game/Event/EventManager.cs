using Sandbox;
using System;

public sealed class EventManager : Component
{
	public static event Action OnPlayerDie;

	public static void PlayerDie()
	{
		OnPlayerDie?.Invoke();
	}
}
