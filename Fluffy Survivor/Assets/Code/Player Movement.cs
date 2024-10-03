using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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
            HealthController.salud -= 1;
            StartCoroutine(Invencivilidad());
            //GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemigo");
            //foreach (GameObject enemy in enemies) {}
        }
    }
    IEnumerator Invencivilidad() 
    {
        GetComponent<Collider2D>().enabled = false;
        GetComponent<SpriteRenderer>().color = Color.green;
        yield return new WaitForSeconds(5);
        GetComponent<SpriteRenderer>().color = Color.white;
        GetComponent<Collider2D>().enabled = true;
        
    }
    
}
