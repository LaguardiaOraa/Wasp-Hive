using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP_Bajar_Dificultad : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Timer.Score += 50;
            DifficultyBar.dificultad += 30f;
            Debug.Log("+100 Puntos");
            this.gameObject.SetActive(false);
        }
    }
}
