using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField]
    private int _score;
    [SerializeField]
    private float _gameTime;

    private float _timerValue;
    private bool _isGameOver;

    public bool IsGameOver => _isGameOver;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _timerValue = _gameTime;
    }

    private void Update()
    {
        StartGameTime();
    }

    public void AddScore(int score)
    {
        _score += score;
    }

    private void StartGameTime()
    {
        _timerValue -= Time.deltaTime;

        if (_timerValue <= 0)
        {
            _timerValue = 0;
            _isGameOver = true;
        }
    }
}
