using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    [SerializeField]
    private Canvas _gameoverCanvas;
    [SerializeField]
    private TextMeshProUGUI _finalScoreText;

    private void Update()
    {
        if (GameManager.Instance.IsGameOver)
        {
            _gameoverCanvas.enabled = true;
            return;
        }

        _finalScoreText.text = $"Score: {GameManager.Instance.Score}";
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
