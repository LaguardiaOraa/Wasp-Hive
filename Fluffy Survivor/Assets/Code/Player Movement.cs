using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public GameObject usuario;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Guarda la posicion actual del mouse
        Vector3 mousePos = Input.mousePosition;
        //Traslada la posicion del mouse a una posicion "dentro del mundo"
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        //Pone la posicion del eje Z a 0, de otro modo se queda a menos 10
        mousePos.z = 0;
        //Lo aplica al objeto
        transform.position = mousePos;

        //Esconde el raton
        Cursor.visible = false;

        //Bloquea el cursor en la pantalla
        Cursor.lockState = CursorLockMode.Confined;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemigo") // Verifica si colisiona con otro objeto "Enemigo"
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemigo");
            //Falta el Game Over
            foreach (GameObject enemy in enemies)
            {
                // Desactiva el GameObject del enemigo para detener su comportamiento
                enemy.SetActive(false);
                Application.Quit();
            }
            
        }
    }

    
}
