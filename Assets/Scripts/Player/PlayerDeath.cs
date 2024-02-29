using System;

public class PlayerDeath : PlayerFinalStateChanger
{
    public event Action OnPlayerDeath;

    public bool Kill(Damager self)
    {
        OnPlayerDeath?.Invoke();
        return base.ChangeState(self);
    }
}