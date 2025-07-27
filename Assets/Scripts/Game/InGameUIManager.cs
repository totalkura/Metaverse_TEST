using TMPro;
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

    UIState currentState = UIState.Main;

    private void Awake()
    {
        instance = this;


    }

}
