using UnityEngine;

public class PlayerMovement : Movement
{
    [SerializeField] private PlayerInputController _inputController;
    [SerializeField] private LayerMask _layerMask;

    private void Update()
    {
        if (_isMoving)
        {
            Move();
            return;
        }
        var direction = _inputController.GetMovementDirection();
        var target = GetMovingTarget(direction);
        StartMoving(target);
    }

    private Vector2 GetMovingTarget(Vector2 direction)
    {
        var converted = ConvertDirection(direction);
        var ray = new Ray2D(_transform.position, converted);
        var hit = Physics2D.Raycast(ray.origin, ray.direction, 1000f, _layerMask);
        return ray.direction * (hit.distance - 0.5f);
    }

    private Vector2 ConvertDirection(Vector2 vector)
    {
        if (Mathf.Abs(vector.x) > Mathf.Abs(vector.y)) vector.y = 0;
        else vector.x = 0;
        return vector.normalized;
    }
}