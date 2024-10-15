using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Reference to the UI Text component to display the top 5 scores

    // List to store top 5 scores
    private List<int> topScores = new List<int>();

    void Start()
    {
        // Load the top scores when the main menu is loaded
        LoadScores();

        // Get the last score saved from the previous gameplay session
        int lastScore = PlayerPrefs.GetInt("LastScore", 0);

        // Add the last score to the list and update the top 5 scores
        AddNewScore(lastScore);

        // Display the updated scores in the main menu
        DisplayScores();
    }

    void LoadScores()
    {
        topScores.Clear();
        for (int i = 1; i <= 5; i++)
        {
            topScores.Add(PlayerPrefs.GetInt("HighScore" + i, 0));
        }
    }

    void SaveScores()
    {
        for (int i = 1; i <= 5; i++)
        {
            PlayerPrefs.SetInt("HighScore" + i, topScores[i - 1]);
        }
        PlayerPrefs.Save();
    }

    public void AddNewScore(int newScore)
    {
        topScores.Add(newScore);
        topScores.Sort();
        topScores.Reverse();

        if (topScores.Count > 5)
        {
            topScores.RemoveAt(topScores.Count - 1);
        }

        SaveScores();
    }

    void DisplayScores()
    {
        scoreText.text = "Top Scores:\n";
        for (int i = 0; i < topScores.Count; i++)
        {
            scoreText.text += (i + 1) + ": " + topScores[i].ToString() + "\n";
        }
    }
}

