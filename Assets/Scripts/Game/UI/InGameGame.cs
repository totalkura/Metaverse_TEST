using TMPro;
using UnityEngine;

public class InGameGame : MonoBehaviour
{
    TextMeshProUGUI scoreText;

    public void Init()
    {
        scoreText = transform.Find("Score").GetComponent<TextMeshProUGUI>();

        Time.timeScale = 1f;
    }

    public void SetUI(int score)
    {
        scoreText.text = score.ToString();
    }
}
