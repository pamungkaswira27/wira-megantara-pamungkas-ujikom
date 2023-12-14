using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuUI : MonoBehaviour
{
    [SerializeField]
    private Canvas _pauseCanvas;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _pauseCanvas.enabled = true;
            Time.timeScale = 0;
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        _pauseCanvas.enabled = false;
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
