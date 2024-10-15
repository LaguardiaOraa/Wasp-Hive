using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemigoBasico;
    public GameObject enemigoVeloz;
    public GameObject enemigoFuerte;
    public int numEnemigos = 2;

    public GameObject Cura;
    public GameObject BajarDificultad;
    public int numPowerUP = 1;

    private int WichPU;
    [SerializeField] private float timeRemaining = 20;

    void Start()
    {
        SpawnEnemigos();
    }

    void SpawnEnemigos()
    {
        for (int i = 0; i < numEnemigos; i++)
        {
            float randomX = Random.Range(-9f, 9f);
            float randomY = Random.Range(-4f, 4f);
            Vector2 randomPosition = new Vector2(randomX, randomY);
            GameObject clon;

            if (DifficultyBar.dificultad <= 100 && DifficultyBar.dificultad >= 66)
            {
                clon = Instantiate(enemigoBasico, randomPosition, Quaternion.identity);
            }
            else if (DifficultyBar.dificultad < 66 && DifficultyBar.dificultad >= 33)
            {
                clon = Instantiate(enemigoVeloz, randomPosition, Quaternion.identity);
            }
            else
            {
                clon = Instantiate(enemigoFuerte, randomPosition, Quaternion.identity);
            }

            clon.SetActive(true);
        }
    }

    void SpawnPowerUP()
    {
        for (int i = 0; i < numPowerUP; i++)
        {
            float randomX = Random.Range(-9f, 9f);
            float randomY = Random.Range(-4f, 4f);
            Vector2 randomPosition = new Vector2(randomX, randomY);
            WichPU = Random.Range(0, 100);
            GameObject clon;

            if (WichPU >= 50)
            {
                clon = Instantiate(Cura, randomPosition, Quaternion.identity);
            }
            else
            {
                clon = Instantiate(BajarDificultad, randomPosition, Quaternion.identity);
            }

            clon.SetActive(true);
        }
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            DifficultyBar.dificultad -= 0.001f;
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            SpawnEnemigos();
            SpawnPowerUP();
            timeRemaining = 30;
        }
    }
}
