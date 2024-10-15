using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DataSaver : MonoBehaviour
{
    // Call this when the game is over and the final score is available
    public void SaveFinalScore()
    {
        // Save the score to PlayerPrefs
        PlayerPrefs.SetInt("LastScore", Timer.Score);
        PlayerPrefs.Save();
    }

    void OnGameOver()
    {
        // Example: Call SaveFinalScore when the game is over
        SaveFinalScore();
    }

}