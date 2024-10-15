using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButtons : MonoBehaviour
{
    public GameObject menuP;

    public void ResumeButton()
    {
        Time.timeScale = 1;
        menuP.SetActive(false);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
