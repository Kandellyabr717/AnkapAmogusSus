using System;
using UnityEngine;

public class EntranceTrigger : PlayerImpactor
{
    public event Action OnEntered;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.gameObject.GetComponent<PlayerEnter>();
        if (player == null) return;
        var enterer = player.Enter(this);
        OnEntered?.Invoke();
    }
}