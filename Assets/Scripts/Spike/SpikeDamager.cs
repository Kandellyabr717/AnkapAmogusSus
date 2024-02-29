using System;
using UnityEngine;

public class SpikeDamager : Damager
{
    public event Action OnKilled;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.gameObject.GetComponent<PlayerDeath>();
        if (player == null) return;
        var killed = player.Kill(this);
        if (killed) OnKilled?.Invoke();
    }
}