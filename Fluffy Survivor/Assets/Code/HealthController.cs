using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    public GameObject vida1, vida2, vida3;
    public static int salud;
    void Start()
    {
        salud = 3;
        vida1.gameObject.SetActive(true);
        vida2.gameObject.SetActive(true);
        vida3.gameObject.SetActive(true);
    }

    public void SaveFinalScore()
    {
        PlayerPrefs.SetInt("LastScore", Timer.Score);
        PlayerPrefs.Save();
    }

    void OnGameOver()
    {    
        SaveFinalScore();
    }

    void Update()
    {
        if(salud > 3) 
        {
            salud = 3;
        }

        switch(salud)
        {
            case 3:
                vida1.SetActive(true);
                vida2.SetActive(true);
                vida3.SetActive(true);
                break;
            case 2:
                vida1.SetActive(true);
                vida2.SetActive(true);
                vida3.SetActive(false);
                break;
            case 1:
                vida1.SetActive(true);
                vida2.SetActive(false);
                vida3.SetActive(false);
                break;
            case 0:
                vida1.SetActive(false);
                vida2.SetActive(false);
                vida3.SetActive(false);
                OnGameOver();
                SceneManager.LoadScene(2);
                break;
        }
    }
}
