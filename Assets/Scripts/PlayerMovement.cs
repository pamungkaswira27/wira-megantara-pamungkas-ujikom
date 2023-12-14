using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private Vector3 _movementDirection;

    private void Update()
    {
        HandleInput();
        MovePlayer();
    }

    private void HandleInput()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        _movementDirection = new Vector3(horizontalInput, 0f, 0f);
    }

    private void MovePlayer()
    {
        transform.position += _speed * Time.deltaTime * _movementDirection;
    }
}
