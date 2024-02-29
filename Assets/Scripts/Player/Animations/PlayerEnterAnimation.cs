using UnityEngine;

public class PlayerEnterAnimation : StateChangeAnimation
{
    protected override void StartAnimation()
    {
        base.StartAnimation();
        _startValue = _transform.localScale;
    }

    protected override void AnimationMove()
    {
        _animationProgress += Time.deltaTime * _speed;
        if (_animationProgress > _startValue.x) StopAnimation();
        var delta = new Vector2(_animationProgress, _animationProgress);
        _transform.localScale = _startValue - delta;
        _transform.Rotate(Vector3.forward, Time.deltaTime * _rotationSpeed);
    }
}