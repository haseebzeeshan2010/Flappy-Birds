using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int score = 0;
    public TMP_Text scoreText;

    public GameObject gameOverScreen;

    [ContextMenu("Add 1 to the score")]
    public void addScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }
    /// <summary>
    /// Restarts the current game scene.
    /// </summary>
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
