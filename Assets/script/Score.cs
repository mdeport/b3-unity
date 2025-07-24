using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int point = 0;
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        UpdateScoreUI();
    }

    public void AddPoints(int points)
    {
        point += points;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        scoreText.text = point.ToString();
    }
}
