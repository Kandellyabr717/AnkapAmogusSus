using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    private PlayerInput _input;

    private void Awake() => _input = new PlayerInput();

    private void OnEnable() => _input.Enable();

    private void OnDisable() => _input.Disable();

    public Vector2 GetMovementDirection() => _input.Player.Movement.ReadValue<Vector2>();
}