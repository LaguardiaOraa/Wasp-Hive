using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMovement : MonoBehaviour
{
    private float speed = 5f;  // Velocidad de Movimiento
    private Vector2 direction; // To store the random direction

    //Elegimos la fuente de audio
    private AudioSource Aplayer;
    //El array donde meteremos todos los clips
    public AudioClip[] clip;

    // Start is called before the first frame update
    void Start()
    {
        //Provoca que seleccione automaticamente como audiosource al objeto que tenga el script
        Aplayer = GetComponent<AudioSource>();
        // Genera una direcci�n aleatoria para el eje X y el eje Y
        float randomX = Random.Range(-1f, 1f);
        float randomY = Random.Range(-1f, 1f);

        //Normalized --> Mantiene la velocidad constante de otra forma esta var�a dependiendo de cuanta distancia ha de recorrer
        direction = new Vector2(randomX, randomY).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        //Aqu� definimos la direccion y la velocidad
        transform.Translate(direction * speed * Time.deltaTime);

        // Esto establece la "existencia" de la camara como algo "tangible" dentro del mundo del juego, para poder interactuar con ella
        Vector2 screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        //Verificar si ha tocado el borde y lo hace rebotar
        if (transform.position.x > screenBounds.x || transform.position.x < -screenBounds.x)
        {
            direction.x = -direction.x; 
        }
        if (transform.position.y > screenBounds.y || transform.position.y < -screenBounds.y)
        {
            direction.y = -direction.y; 
        }
    }

    //Si colisiona con otro como el, rebote
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemigo") // Verifica si colisiona con otro objeto "Enemigo"
        {
            //Especificamos que el clip a seleccionar coincide con el numero de nuestro valorRandom
            Aplayer.clip = clip[2];
            //Reproducimos el clip
            Aplayer.Play();
            //Debug.Log("Colisi�n detectada con otro Enemigo"); //Cada vez que se active que suelte una linea en el log
            ContactPoint2D contactPoint = collision.GetContact(0); //Registra el primer punto de contacto
            Vector2 normal = contactPoint.normal;
            direction = Vector2.Reflect(direction, normal); // Y aqui invertimos la direccion
        }
    }
}

