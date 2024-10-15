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
        // Load the saved score
        score = PlayerPrefs.GetInt("HighScore", 0);
        Debug.Log("Score loaded: " + score); // Debugging line to confirm load
        // Update the UI Text with the score
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        // Set the Text to display the score
        scoreText.text = "Score: " + score.ToString();
    }
}
