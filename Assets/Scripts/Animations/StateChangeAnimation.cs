using UnityEngine;

public abstract class StateChangeAnimation : MonoBehaviour
{
    [SerializeField] protected Transform _transform;
    [SerializeField] private PlayerStateChanger _changer;
    [SerializeField] protected float _speed;
    [SerializeField] protected float _rotationSpeed;

    protected bool _isStarted = false;
    protected Vector2 _startValue;
    protected float _animationProgress;

    private void OnEnable() => _changer.OnPlayerStateChanged += StartAnimation;

    private void OnDisable() => _changer.OnPlayerStateChanged -= StartAnimation;

    private void OnDestroy() => _changer.OnPlayerStateChanged -= StartAnimation;

    private void Update()
    {
        if (_isStarted) AnimationMove();
    }

    protected virtual void StartAnimation()
    {
        _isStarted = true;
        _transform.rotation = Quaternion.identity;
    }

    protected abstract void AnimationMove();

    protected virtual void StopAnimation() => _isStarted = false;
}