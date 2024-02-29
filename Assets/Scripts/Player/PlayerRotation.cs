using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private PlayerMovement _movement;

    private void OnEnable()
    {
        _movement.OnMovingStart += RotateToDirection;
        _movement.OnMovingStop += RotateToNormal;
    }

    private void OnDisable()
    {
        _movement.OnMovingStart -= RotateToDirection;
        _movement.OnMovingStop -= RotateToNormal;
    }

    private void OnDestroy()
    {
        _movement.OnMovingStart -= RotateToDirection;
        _movement.OnMovingStop -= RotateToNormal;
    }

    private void RotateToDirection(Vector2 movementTarget) => BaseRotate(movementTarget.normalized);

    private void RotateToNormal(Vector2 movementTarget) => BaseRotate(-movementTarget.normalized);

    private void BaseRotate(Vector2 normal)
    {
        _transform.rotation = Quaternion.identity;
        var angle = Vector2.Angle(normal, Vector2.up);
        if (normal.x > 0)
        {
            angle -= 180;
        }
        _transform.Rotate(Vector3.forward, angle);
    }
}