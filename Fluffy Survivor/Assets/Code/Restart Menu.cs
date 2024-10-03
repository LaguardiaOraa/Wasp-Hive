using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Boton Restart
    public void OnRestartButton()
    {
        SceneManager.LoadScene(1);
    }

    //Boton Main Menu
    public void OnMainMenuButton()
    {
        SceneManager.LoadScene(0);
    }

}
