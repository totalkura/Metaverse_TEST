using UnityEngine;

public enum UIState
{
    Main,
    Game,
    Score,
}

public class InGameUIManager : MonoBehaviour
{
    static InGameUIManager instance;

    public static InGameUIManager Instance
    {
        get {return instance;}
    }

    InGameScore inGameScore = null;
    InGameGame inGameGame = null;
    InGameMain inGameMain = null;


    UIState currentState = UIState.Main;

    private void Awake()
    {
        instance = this;

        inGameGame = GetComponentInChildren<InGameGame>(true);
        inGameGame?.Init();

        inGameScore = GetComponentInChildren<InGameScore>(true);
        inGameScore?.Init();

        inGameMain = GetComponentInChildren<InGameMain>(true);
        inGameMain?.Init();

        ChangeState(UIState.Main);

    }

    public void ChangeState(UIState state)
    {
        currentState = state;
        inGameGame?.gameObject.SetActive(state == UIState.Game);
        inGameScore?.gameObject.SetActive(state == UIState.Score);
        inGameMain?.gameObject.SetActive(state == UIState.Main);
    }

    public void SetScoreUI(int score, int bestScore)
    {
        inGameScore.SetUI(score, bestScore);
    }

    public void UpdateScore(int score)
    {
        inGameGame.SetUI(score);
    }

    public void GameOver()
    {
        ChangeState(UIState.Score);
    }

    public void OnClickStartButton()
    {
        inGameMain.OnClickStartButton();
        ChangeState(UIState.Game);
    }
}
