using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int enemiesToDefeat = 5;
    private int defeatedEnemies = 0;

    public GameObject winPanel;
    public TextMeshProUGUI winText;

    public GameObject losePanel;
    public TextMeshProUGUI loseText;

    public Button restartButtonWin;
    public Button restartButtonLose;
    public Button exitButton;

    void Start()
    {
        winPanel.SetActive(false);
        losePanel.SetActive(false);

        restartButtonWin.onClick.AddListener(RestartGame);
        restartButtonLose.onClick.AddListener(RestartGame);
        exitButton.onClick.AddListener(ExitGame);
    }

    public void EnemyDefeated()
    {
        defeatedEnemies++;
        if (defeatedEnemies >= enemiesToDefeat)
        {
            ShowVictoryScreen();
        }
    }

    void ShowVictoryScreen()
    {
        winText.text = "VICTORY";
        winPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void GameOver()
    {
        loseText.text = "GAME OVER";
        losePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void ExitGame()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
