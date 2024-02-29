using System;
using UnityEngine;

public class SpikeTrigger : MonoBehaviour
{
    public event Action OnTriggerEnter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerDeath>() != null) OnTriggerEnter?.Invoke();
    }
}