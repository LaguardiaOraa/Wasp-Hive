using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    public float elapsedTime;
    public static int Score = 0;

    void Update()
    {
        elapsedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (DifficultyBar.dificultad >= 66)
        {
            Score += 1;
        }
        else if (DifficultyBar.dificultad >= 33)
        {
            Score += 5;
        }
        else
        {
            Score += 10;
        }
    }
}
