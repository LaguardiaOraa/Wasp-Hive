using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweUP_Cura : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") // Verifica si colisiona con Jugador
        {
            HealthController.salud += 1;
            this.gameObject.SetActive(false);
        }
    }
}
