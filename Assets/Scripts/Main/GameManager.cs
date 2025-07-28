using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager gameManager;
    public static GameManager Instance { get { return gameManager; } }

    UIManager uiManager;

    private float HighScore;
    private float LastScore;

    private void Awake()
    {
        gameManager = this;


        uiManager = FindObjectOfType<UIManager>();

        HighScore = PlayerPrefs.GetFloat("MaxScore", 0f);
        LastScore = PlayerPrefs.GetFloat("NowScore", 0f);

    }


    void Start()
    {
        uiManager.SetUI((int)LastScore, (int)HighScore);
    }

}
