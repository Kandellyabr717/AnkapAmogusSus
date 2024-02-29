using UnityEngine;

public class ContactSpikes : MonoBehaviour
{
    [SerializeField] private SpikeMovement _movement;
    [SerializeField] private SpikeTrigger _trigger;
    [SerializeField] private Timer _timer;

    private void OnEnable()
    {
        _trigger.OnTriggerEnter += _timer.StartTiming;
        _timer.OnTimingEnd += _movement.StartMoving;
    }

    private void OnDisable()
    {
        _trigger.OnTriggerEnter -= _timer.StartTiming;
        _timer.OnTimingEnd -= _movement.StartMoving;
    }

    private void OnDestroy()
    {
        _trigger.OnTriggerEnter -= _timer.StartTiming;
        _timer.OnTimingEnd -= _movement.StartMoving;
    }
}