using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSaver : MonoBehaviour
{
    public void SaveFinalScore()
    {
        PlayerPrefs.SetInt("LastScore", Timer.Score);
        PlayerPrefs.Save();
    }

    void OnGameOver()
    {
        SaveFinalScore();
    }
}
