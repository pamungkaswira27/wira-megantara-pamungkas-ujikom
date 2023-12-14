using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField]
    private int _hungerNeed;
    [SerializeField]
    private int _scorePoint;
    [SerializeField]
    private float _speed;

    private int _currentHungerNeed;

    private void Start()
    {
        _currentHungerNeed = 0;
    }

    private void Update()
    {
        MoveAnimal();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boundary"))
        {
            Destroy(gameObject);
        }
    }

    public void FeedAnimal(int hungerValue)
    {
        _currentHungerNeed += hungerValue;

        if (_currentHungerNeed >= _hungerNeed)
        {
            _currentHungerNeed = _hungerNeed;
            GameManager.Instance.AddScore(_scorePoint);
            Destroy(gameObject);
        }
    }

    private void MoveAnimal()
    {
        transform.position += _speed * Time.deltaTime * transform.forward;
    }
}
