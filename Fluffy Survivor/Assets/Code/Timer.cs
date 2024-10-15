using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    public float elapsedTime;
    public static int Score = 0;

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        if (DifficultyBar.dificultad <= 100 && DifficultyBar.dificultad >= 66)
        {
            Score =Score + 1;
        }
        else if (DifficultyBar.dificultad < 66 && DifficultyBar.dificultad >= 33)
        {
            Score = Score + 5;
        }
        else
        {
            Score = Score + 10;
        }
    }

    
}
