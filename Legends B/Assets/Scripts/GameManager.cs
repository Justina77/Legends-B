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
    public Button restartButton;

    void Start()
    {
        winPanel.SetActive(false);
        restartButton.onClick.AddListener(RestartGame);
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
        winPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    void RestartGame()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
