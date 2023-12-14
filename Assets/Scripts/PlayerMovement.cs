using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private float _speed;

    private Vector3 _movementDirection;

    private void Update()
    {
        if (GameManager.Instance.IsGameOver)
        {
            _animator.SetTrigger("GameOver");
            return;
        }

        HandleInput();
        MovePlayer();
        Animate();
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

    private void Animate()
    {
        int movementDirection = 0;

        if (_movementDirection.x > 0f)
        {
            movementDirection = 1;
        }
        else if (_movementDirection.x < 0f)
        {
            movementDirection = -1;
        }

        _animator.SetInteger("Movement", movementDirection);
    }
}
