using System.Collections;
using TMPro;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    public float time = 45f;
    public TextMeshProUGUI TimeText;
    public GameObject canvasGameOver;
    public GameObject canvasVictoire;
    public TextMeshProUGUI Score;

    private bool isTimerRunning = true;

    private void Start()
    {
        canvasGameOver.SetActive(false);
        canvasVictoire.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        while (time > 0 && isTimerRunning)
        {
            TimeText.text = time.ToString("0");
            yield return new WaitForSeconds(1f);
            time--;

            if (int.TryParse(Score.text, out int currentScore))
            {
                if (currentScore >= 10)
                {
                    isTimerRunning = false;
                    canvasVictoire.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    yield break;
                }
            }
        }

        if (isTimerRunning)
        {
            TimeText.text = "0";
            canvasGameOver.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

}
