using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButtons : MonoBehaviour
{
    public GameObject menuP;
    
    // Called when we click the "Play" button.
    public void ResumeButton()
    {
        // Set Time.timeScale back to 1 to resume gameplay
        Time.timeScale = 1;
        // Hide PauseMenu panel (deactivate its gameObject)
        menuP.gameObject.SetActive(false);
    }
    // Called when we click the "Quit" button.
    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
