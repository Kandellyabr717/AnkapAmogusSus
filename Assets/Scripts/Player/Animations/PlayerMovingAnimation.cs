using UnityEngine;

public class PlayerMovingAnimation : SpriteAnimation
{
    [SerializeField] private PlayerMovement _movement;

    private void OnEnable()
    {
        _movement.OnMovingStart += target => ChamgeToActive();
        _movement.OnMovingStop += target => ChngeToMain();
    }

    private void OnDisable()
    {
        _movement.OnMovingStart -= target => ChamgeToActive();
        _movement.OnMovingStop -= target => ChngeToMain();
        ChngeToMain();
    }

    private void OnDestroy()
    {
        _movement.OnMovingStart -= target => ChamgeToActive();
        _movement.OnMovingStop -= target => ChngeToMain();
        ChngeToMain();
    }
}