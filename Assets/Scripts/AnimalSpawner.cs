using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _animalPrefabs;
    [SerializeField]
    private Transform[] _spawnPoints;
    [SerializeField]
    private float _spawnInterval;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnAnimal), _spawnInterval, _spawnInterval);
    }

    private void SpawnAnimal()
    {
        if (GameManager.Instance.IsGameOver)
        {
            return;
        }

        int animalRandomIndex = Random.Range(0, _animalPrefabs.Length);
        int spawnPointRandomIndex = Random.Range(0, _spawnPoints.Length);

        Quaternion spawnRotation = Quaternion.Euler(0f, 180f, 0f);

        Instantiate(_animalPrefabs[animalRandomIndex], _spawnPoints[spawnPointRandomIndex].position, spawnRotation, _spawnPoints[spawnPointRandomIndex]);
    }
}
