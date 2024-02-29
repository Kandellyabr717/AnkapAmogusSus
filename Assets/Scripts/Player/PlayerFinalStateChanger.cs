using UnityEngine;

public abstract class PlayerFinalStateChanger : PlayerStateChanger
{
    [SerializeField] private PlayerMovement _movement;
    [SerializeField] private PlayerMovingAnimation _movingAnimation;
    [SerializeField] private PlayerRotation _rotation;
    [SerializeField] private BoxCollider2D _collider;
    [SerializeField] private CameraMovement _cameraMovement;

    protected override bool ChangeState(PlayerImpactor self)
    {
        if (!base.ChangeState(self)) return false;
        _movement.enabled = false;
        _movingAnimation.enabled = false;
        _rotation.enabled = false;
        _collider.enabled = false;
        _cameraMovement.enabled = false;
        return true;
    }
}