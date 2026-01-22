using UnityEngine;
using UnityEngine.SceneManagement;// For scene management
using TMPro; // For TextMeshPro UI elements


public class GameManager : MonoBehaviour
{
    public int ballsLeft = 3;
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private Transform spawnPoint;

    [SerializeField] private TMP_Text ballcount_Text;
    [SerializeField] private GameObject gameOverScreen;

    private void Start()
    {
        ballcount_Text.text = ballsLeft.ToString();
    }

    // Call this method to handle ball loss
    public void BallLost ()
    {
        ballsLeft--;
        ballcount_Text.text = ballsLeft.ToString();
        if (ballsLeft > 0)
        {
           
            Debug.Log("Ball Lost! Spawning new ball. Balls left: " + ballsLeft);
        }
        else
        {
            //restart game or show game over screen
            Debug.Log("Game Over Restart the scene!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            gameOverScreen.SetActive(true);

        }
    }
    public void RestartGame()
        {
            
    }

}

