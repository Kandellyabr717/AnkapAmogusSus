using System;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _duration;

    private bool _isTiming = false;
    private float _time;

    public event Action OnTimingEnd;

    private void Update()
    {
        if (_isTiming) Tick();
    }

    public void StartTiming()
    {
        _isTiming = true;
        _time = 0;
    }

    private void Tick()
    {
        _time += Time.deltaTime / _duration;
        if (_time > 1) StopTiming();
    }

    private void StopTiming()
    {
        _isTiming = false;
        _time = 0;
        OnTimingEnd?.Invoke();
    }
}