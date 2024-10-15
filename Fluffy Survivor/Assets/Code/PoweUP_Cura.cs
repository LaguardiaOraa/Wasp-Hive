using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PoweUP_Cura : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") // Verifica si colisiona con Jugador
        {
            Timer.Score += 100;
            HealthController.salud += 1;
            Debug.Log("+100 Puntos");
            this.gameObject.SetActive(false);
        }
    }
}
