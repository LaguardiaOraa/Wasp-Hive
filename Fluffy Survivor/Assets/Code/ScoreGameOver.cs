using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreGameOver : MonoBehaviour
{
    public int score; // Your score variable
    public TextMeshProUGUI scoreText; // Reference to the UI Text component

    void Start()
    {
        // Get the score from PlayerPrefs (this is the score from the last game)
        int lastScore = PlayerPrefs.GetInt("LastScore", 0);

        // Display the score on the Game Over screen
        scoreText.text = "Your Score: " + lastScore.ToString();
    }
}
