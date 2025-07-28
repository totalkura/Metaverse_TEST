using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager gameManager;
    public static GameManager Instance { get { return gameManager; } }

    UIManager uiManager;
    PlayerMove playerMover;

    private float highScore;
    private float lastScore;

    private bool action = false;

    private void Awake()
    {
        gameManager = this;


        uiManager = FindObjectOfType<UIManager>();
        playerMover = FindObjectOfType<PlayerMove>();

        highScore = PlayerPrefs.GetFloat("MaxScore", 0f);
        lastScore = PlayerPrefs.GetFloat("NowScore", 0f);

    }



    void Start()
    {
        uiManager.SetUI((int)lastScore, (int)highScore);
    }

    private void Update()
    {
        uiManager.SetConver(playerMover.npc);
    }


}
