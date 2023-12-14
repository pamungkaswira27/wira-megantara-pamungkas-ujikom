using UnityEngine;

public class PlayerThrow : MonoBehaviour
{
    [SerializeField]
    private GameObject _foodPrefab;
    [SerializeField]
    private Transform _throwPoint;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            ThrowFood();
        }
    }

    private void ThrowFood()
    {
        Instantiate(_foodPrefab, _throwPoint.position, Quaternion.identity);
    }
}
