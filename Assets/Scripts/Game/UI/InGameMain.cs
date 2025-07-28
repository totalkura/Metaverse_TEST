using UnityEngine;
using UnityEngine.UI;

public class InGameMain : MonoBehaviour
{
    Button startButton;

    public void Init()
    {
        startButton = transform.Find("StartButton").GetComponent<Button>();

        startButton.onClick.AddListener(OnClickStartButton);

    }

    public void OnClickStartButton()
    {
        Time.timeScale = 1f;
    }

}
