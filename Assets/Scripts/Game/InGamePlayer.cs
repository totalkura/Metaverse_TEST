using UnityEngine;

public class InGamePlayer : MonoBehaviour
{
    public bool deathCheck = false;

    InGameManager inGameManager;

    void Start()
    {
        inGameManager = InGameManager.Instance;
    }

    void Update()
    {
    }
}
