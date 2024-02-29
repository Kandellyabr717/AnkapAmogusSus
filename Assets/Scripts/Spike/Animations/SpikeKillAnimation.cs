using UnityEngine;

public class SpikeKillAnimation : SpriteAnimation
{
    [SerializeField] private SpikeDamager _damager;

    private void OnEnable() => _damager.OnKilled += ChamgeToActive;

    private void OnDisable()
    {
        _damager.OnKilled -= ChamgeToActive;
        ChngeToMain();
    }

    private void OnDestroy()
    {
        _damager.OnKilled -= ChamgeToActive;
        ChngeToMain();
    }
}