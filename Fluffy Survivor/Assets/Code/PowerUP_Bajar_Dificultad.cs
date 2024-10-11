using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP_Bajar_Dificultad : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") // Verifica si colisiona con Jugador
        {
            DifficultyBar.dificultad += 30f;
            //Aqui el codigo
            this.gameObject.SetActive(false);
        }
    }
}
