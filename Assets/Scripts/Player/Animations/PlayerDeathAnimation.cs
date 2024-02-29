using UnityEngine;

public class PlayerDeathAnimation : StateChangeAnimation
{
    [SerializeField] private AnimationCurve _horizontal;
    [SerializeField] private AnimationCurve _vertical;
    [SerializeField] private GameObject _blood;

    protected override void StartAnimation()
    {
        base.StartAnimation();
        _startValue = _transform.position;
        Instantiate(_blood, _startValue, Quaternion.identity);
    }

    protected override void AnimationMove()
    {
        _animationProgress += Time.deltaTime * _speed;
        if (_animationProgress > _horizontal.keys[_horizontal.length - 1].time) StopAnimation();
        var x = _horizontal.Evaluate(_animationProgress);
        var y = _vertical.Evaluate(_animationProgress);
        var delta = new Vector2(x, y);
        _transform.position = _startValue + delta;
        _transform.Rotate(Vector3.forward, Time.deltaTime * _rotationSpeed);
    }
}