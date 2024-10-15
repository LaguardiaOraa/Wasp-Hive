using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DataSaver : MonoBehaviour
{
    void Update()
    {
        PlayerPrefs.SetInt("HighScore", Timer.Score); // Save the score with the key "HighScore"
        PlayerPrefs.Save(); // Ensure it's written to disk
    }
}