using UnityEngine;

public class AlternatingSpike : MonoBehaviour
{
    [SerializeField] private SpikeMovement _movement;
    [SerializeField] private Timer _timer;

    private void OnEnable()
    {
        _timer.OnTimingEnd += _movement.StartMoving;
        _movement.OnMovingStop += targer => _timer.StartTiming();
    }

    private void OnDisable()
    {
        _timer.OnTimingEnd -= _movement.StartMoving;
        _movement.OnMovingStop -= targer => _timer.StartTiming();
    }

    private void OnDestroy()
    {
        _timer.OnTimingEnd -= _movement.StartMoving;
        _movement.OnMovingStop -= targer => _timer.StartTiming();
    }

    private void Start() => _timer.StartTiming();
}