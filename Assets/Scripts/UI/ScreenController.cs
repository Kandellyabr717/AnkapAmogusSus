using UnityEngine;

public class ScreenController : MonoBehaviour
{
    [SerializeField] private PlayerDeath _death;
    [SerializeField] private PlayerEnter _enter;
    [SerializeField] private ScreenActivator _winScreen;
    [SerializeField] private ScreenActivator _deathScreen;

    private void OnEnable()
    {
        _death.OnPlayerDeath += _deathScreen.Activate;
        _enter.OnPlayerEnter += _winScreen.Activate;
    }

    private void OnDisable()
    {
        _death.OnPlayerDeath -= _deathScreen.Activate;
        _enter.OnPlayerEnter -= _winScreen.Activate;
    }

    private void OnDestroy()
    {
        _death.OnPlayerDeath -= _deathScreen.Activate;
        _enter.OnPlayerEnter -= _winScreen.Activate;
    }
}