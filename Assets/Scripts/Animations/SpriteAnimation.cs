using UnityEngine;

public abstract class SpriteAnimation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Sprite _main;
    [SerializeField] private Sprite _active;

    protected void ChamgeToActive() => _renderer.sprite = _active;

    protected void ChngeToMain() => _renderer.sprite = _main;
}
