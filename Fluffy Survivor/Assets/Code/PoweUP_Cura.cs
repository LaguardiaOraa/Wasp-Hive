using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PoweUP_Cura : MonoBehaviour
{
    //Elegimos la fuente de audio
    private AudioSource Aplayer;
    //El array donde meteremos todos los clips
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        //Provoca que seleccione automaticamente como audiosource al objeto que tenga el script
        Aplayer = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") // Verifica si colisiona con Jugador
        {
            //Reproducimos el clip
            Aplayer.Play();
            HealthController.salud += 1;
            this.gameObject.SetActive(false);
        }
    }
}
