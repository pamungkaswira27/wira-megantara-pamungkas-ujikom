using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField]
    private int _hungerValue;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _lifetime;

    private void Start()
    {
        Destroy(gameObject, _lifetime);
    }

    private void Update()
    {
        MoveFood();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Animal animal))
        {
            animal.FeedAnimal(_hungerValue);
            Destroy(gameObject);
        }
    }

    private void MoveFood()
    {
        transform.position += _speed * Time.deltaTime * Vector3.forward;
    }
}
