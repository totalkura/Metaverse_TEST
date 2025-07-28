using UnityEngine;

public class InGameManager : MonoBehaviour
{
    static InGameManager inGameManager;
    public static InGameManager Instance { get { return inGameManager; } }

    InGameUIManager inGameUIManager;
    public InGameUIManager InGameUIManager { get { return InGameUIManager; } }

    private int currentScore = 0;
    private float maxScore;

    private void Awake()
    {
        inGameManager = this;
        inGameUIManager = FindObjectOfType<InGameUIManager>();

        maxScore = PlayerPrefs.GetFloat("MaxScore",0f);

        Time.timeScale = 0f;
    }

    private void Start()
    {
        inGameUIManager.UpdateScore(0);
    }

    private void Update()
    {
           
    }

    public int Score()
    {
        return currentScore;
    }

    public int BestScore()
    {
        return (int)maxScore;
    }

    public void AddScore(int score)
    {
        currentScore += score;
        inGameUIManager.UpdateScore((int)currentScore);
    }

    public void Gameover()
    {
        inGameUIManager.GameOver();
        if (currentScore > (int)maxScore)
            PlayerPrefs.SetFloat("MaxScore", currentScore);
        else
            PlayerPrefs.SetFloat("NowScore", currentScore);
        inGameUIManager.SetScoreUI(currentScore,(int)maxScore);
    }
}
