using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager gameManager;
    public static GameManager Instance { get { return gameManager; } }

    public GameObject Fire;

    UIManager uiManager;
    PlayerMove playerMover;

    private float highScore;
    private float lastScore;

    private string effects;

    private bool fireOn = false;
    private void Awake()
    {
        gameManager = this;

        //PlayerPrefs.SetString("Effect", "");
        fireOn = PlayerPrefs.GetString("Effect", "")=="True" ? true:false;


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
        effects = PlayerPrefs.GetString("Effect", "");
        if (effects == "True")
        {
            uiManager.SetConver(playerMover.npc, false, true);
            if(!fireOn)
                Fire.SetActive(true);
        }
        else uiManager.SetConver(playerMover.npc, playerMover.born);
    }


}
