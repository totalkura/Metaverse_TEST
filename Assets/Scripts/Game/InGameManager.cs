using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameManager : MonoBehaviour
{
    static InGameManager inGameManager;
    public static InGameManager Instance { get { return inGameManager; } }

    InGameUIManager inGameUIManager;
    public InGameUIManager InGameUIManager { get { return InGameUIManager; } }

    private int currentScore = 0;

    private void Awake()
    {
        inGameManager = this;
        inGameUIManager = FindObjectOfType<InGameUIManager>();
    }

    private void Start()
    {
        inGameUIManager.UpdateScore(0);
    }

    public void GameOver()
    {
        inGameUIManager.ShowScore();
    }

    public void ReturnMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void AddScore(int score)
    {
        currentScore += score;
        inGameUIManager.UpdateScore(currentScore);
    }
}
