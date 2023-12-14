using TMPro;
using UnityEngine;

public class GameplayUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _scoreText;
    [SerializeField]
    private TextMeshProUGUI _timerText;

    private void Update()
    {
        UpdateGameplayUI();
    }

    private void UpdateGameplayUI()
    {
        _scoreText.text = $"Score: {GameManager.Instance.Score}";
        _timerText.text = $"Timer: {Mathf.RoundToInt(GameManager.Instance.GameTime)}";
    }
}
