using System;

public class PlayerEnter : PlayerFinalStateChanger
{
    public event Action OnPlayerEnter;

    public bool Enter(EntranceTrigger self)
    {
        OnPlayerEnter?.Invoke();
        return base.ChangeState(self);
    }
}