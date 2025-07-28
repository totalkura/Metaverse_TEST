using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;

    public GameObject ConverImage;
    public GameObject ConverImage2;
    public GameObject ConverImage3;

    public void SetUI(int score, int bestScore)
    {
        scoreText.text = score.ToString();
        bestScoreText.text = bestScore.ToString();
    }

    public void SetConver(bool onOne, bool onTwo,bool Fire = false)
    {
        ConverImage.SetActive(onOne);
        ConverImage2.SetActive(onTwo);
        ConverImage3.SetActive(Fire);
    }


}
