using UnityEngine;

public class SpikeMovement : Movement
{
    private void Update()
    {
        if (!_isMoving) return;
        Move();
    }

    public override void StartMoving() => StartMoving(Quaternion.Euler(_transform.eulerAngles) * Vector2.up);
}