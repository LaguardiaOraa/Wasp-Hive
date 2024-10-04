using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    //Elegimos la fuente de audio
    private AudioSource Aplayer;
    //El array donde meteremos todos los clips
    public AudioClip[] clip;

    // Start is called before the first frame update
    void Start()
    {
        //Provoca que seleccione automaticamente como audiosource al objeto que tenga el script
        Aplayer = GetComponent<AudioSource>();
    }


   
}
