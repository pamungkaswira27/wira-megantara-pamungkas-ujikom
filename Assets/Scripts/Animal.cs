using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField]
    private int _hungerNeed;
    [SerializeField]
    private int _scorePoint;
    [SerializeField]
    private float _speed;

    private void Update()
    {
        MoveAnimal();
    }

    private void MoveAnimal()
    {
        transform.position += _speed * Time.deltaTime * Vector3.forward;
    }
}
