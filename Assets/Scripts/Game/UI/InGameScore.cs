using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGameScore : MonoBehaviour
{
    TextMeshProUGUI scoreText;
    TextMeshProUGUI bestScoreText;

    Button returnButton;

    public void Init()
    {
        scoreText = transform.Find("NowScore").GetComponent<TextMeshProUGUI>();
        bestScoreText = transform.Find("BestScore").GetComponent <TextMeshProUGUI>();
        returnButton = transform.Find("ReturnButton").GetComponent<Button>();

        returnButton.onClick.AddListener(OnClickReturnButton);

        Time.timeScale = 0f;

    }

    public void SetUI(int score,int bestScore)
    {
        scoreText.text = score.ToString();
        bestScoreText.text = bestScore.ToString();
    }

    public void OnClickReturnButton()
    {
        SceneManager.LoadScene("MainScene");
    }
}
