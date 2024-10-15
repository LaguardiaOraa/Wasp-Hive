using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreGameOver : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        int lastScore = PlayerPrefs.GetInt("LastScore", 0);
        scoreText.text = "Your Score: " + lastScore.ToString();
    }
}
