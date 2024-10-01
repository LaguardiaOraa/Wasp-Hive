using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Anadir para movernos entre escenas
public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Boton Play
    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
    }

    //Boton Quit
    public void OnQuitButton()
    {
        Application.Quit();
    }
}
