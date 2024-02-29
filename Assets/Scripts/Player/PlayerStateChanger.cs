using System;
using UnityEngine;

public abstract class PlayerStateChanger : MonoBehaviour
{
    public event Action OnPlayerStateChanged;

    protected virtual bool ChangeState(PlayerImpactor self)
    {
        if (self == null) return false;
        OnPlayerStateChanged?.Invoke();
        return true;
    }
}