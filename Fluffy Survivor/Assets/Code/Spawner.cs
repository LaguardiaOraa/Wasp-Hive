using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemigoPrefab; // Referencia al prefab del objeto que está desactivado
    public int numEnemigos = 2;      // Número de enemigos a instanciar

    //Declaro el temporizador, Serialized establece que no puede ser modificado ni accedido fuera de este script
    [SerializeField] public float timeRemaining = 30;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemigos();
    }
    void SpawnEnemigos()
    {
        for (int i = 0; i < numEnemigos; i++)
        {
            // Genera una posición aleatoria entre X 9 y Y 4
            float randomX = Random.Range(-9f, 9f);
            float randomY = Random.Range(-4f, 4f);

            // Crea un Vector2 con la posición generada
            Vector2 randomPosition = new Vector2(randomX, randomY);

            // Instancia el objeto en la posición aleatoria, pero desactivado
            GameObject clon = Instantiate(enemigoPrefab, randomPosition, Quaternion.identity);

            // Activa el clon después de instanciarlo
            clon.SetActive(true);
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
            //Aquí el spawneo
            SpawnEnemigos();
            timeRemaining = 30;
        }
    }
}
