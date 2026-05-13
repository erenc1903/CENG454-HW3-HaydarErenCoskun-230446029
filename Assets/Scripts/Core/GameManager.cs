using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public float surviveTime = 60f;

    private float timer;
    private bool gameEnded = false;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        Time.timeScale = 1f;
        timer = surviveTime;
    }

    void Update()
    {
        if (gameEnded) return;

        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            WinGame();
        }
    }

    public void GameOver()
    {
        if (gameEnded) return;

        gameEnded = true;
        Debug.Log("GAME OVER");
        Time.timeScale = 0f;
    }

    public void WinGame()
    {
        if (gameEnded) return;

        gameEnded = true;
        Debug.Log("YOU WIN");
        Time.timeScale = 0f;
    }
}