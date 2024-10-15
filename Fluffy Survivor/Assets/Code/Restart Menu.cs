using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
    }

    void Update()
    {
    }

    public void OnRestartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void OnMainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
