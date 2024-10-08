using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemigoPrefab; // Referencia al prefab del objeto que est� desactivado
    public int numEnemigos = 2;      // N�mero de enemigos a instanciar

    public GameObject Cura;
    public GameObject BajarDificultad;
    public int numPowerUP = 1;

    private int WichPU;

    //Declaro el temporizador, Serialized establece que no puede ser modificado ni accedido fuera de este script
    [SerializeField] private float timeRemaining = 20;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemigos();
    }
    void SpawnEnemigos()
    {
        for (int i = 0; i < numEnemigos; i++)
        {
            // Genera una posici�n aleatoria entre X 9 y Y 4
            float randomX = Random.Range(-9f, 9f);
            float randomY = Random.Range(-4f, 4f);

            // Crea un Vector2 con la posici�n generada
            Vector2 randomPosition = new Vector2(randomX, randomY);

            // Instancia el objeto en la posici�n aleatoria, pero desactivado
            GameObject clon = Instantiate(enemigoPrefab, randomPosition, Quaternion.identity);

            // Activa el clon despu�s de instanciarlo
            clon.SetActive(true);
        }
    }

    void SpawnPowerUP()
    {
        for (int i = 0; i < numPowerUP; i++)
        {
            // Genera una posici�n aleatoria entre X 9 y Y 4
            float randomX = Random.Range(-9f, 9f);
            float randomY = Random.Range(-4f, 4f);

            // Crea un Vector2 con la posici�n generada
            Vector2 randomPosition = new Vector2(randomX, randomY);
            WichPU=Random.Range(0,100);
            if(WichPU>=70)
            {
                GameObject clon = Instantiate(Cura, randomPosition, Quaternion.identity);
                clon.SetActive(true);
            }
            else
            {
                GameObject clon = Instantiate(BajarDificultad, randomPosition, Quaternion.identity);
                clon.SetActive(true);
            }
            // Instancia el objeto en la posici�n aleatoria, pero desactivado
            //GameObject clon = Instantiate(Cura, randomPosition, Quaternion.identity);

            // Activa el clon despu�s de instanciarlo
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            //Aqu� el spawneo
            SpawnEnemigos();
            
            SpawnPowerUP();
            timeRemaining = 30;
        }
    }
}
