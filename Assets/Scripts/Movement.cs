using System;
using UnityEngine;

public abstract class Movement : MonoBehaviour
{
    public bool IsMoving { get => _isMoving; }

    [SerializeField] protected Transform _transform;
    [SerializeField] protected AnimationCurve _curve;
    [SerializeField] protected float _speed;

    protected bool _isMoving = false;
    protected Vector2 _startPosition;
    protected Vector2 _movementTarget;
    protected float _movementProgress;

    public event Action<Vector2> OnMovingStart;
    public event Action<Vector2> OnMovingStop;

    protected void StartMoving(Vector2 target)
    {
        if (target == Vector2.zero || _isMoving) return;
        _isMoving = true;
        _startPosition = _transform.position;
        _movementTarget = target;
        _movementProgress = 0;
        OnMovingStart?.Invoke(_movementTarget);
    }

    public virtual void StartMoving() { }

    protected void Move()
    {
        _movementProgress += Time.deltaTime * _speed / _movementTarget.magnitude;
        _movementProgress = Mathf.Min(_movementProgress, 1);
        var delta = _movementTarget * _curve.Evaluate(_movementProgress);
        _transform.position = _startPosition + delta;
        if (_movementProgress == 1) StopMoving();
    }

    private void StopMoving()
    {
        OnMovingStop?.Invoke(_movementTarget);
        _isMoving = false;
        _startPosition = Vector2.zero;
        _movementTarget = Vector2.zero;
        _movementProgress = 0;
    }
}