using System;
using UnityEngine;

public class CoinTrigger : PlayerImpactor
{
    public event Action OnPicked;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.gameObject.GetComponent<PlayerCoinPicker>();
        if (player == null) return;
        var picked = player.PickCoin(this);
        if (picked)
        {
            OnPicked?.Invoke();
            Destroy(gameObject);
        }
    }
}