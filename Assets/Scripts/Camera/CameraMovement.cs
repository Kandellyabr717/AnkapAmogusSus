using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private Transform _player;
    [SerializeField] private float _speed;

    private void Update()
    {
        var delta = new Vector3(_player.position.x - _transform.position.x, 
                                _player.position.y - _transform.position.y);
        _transform.position += delta * Time.deltaTime * _speed;
    }
}