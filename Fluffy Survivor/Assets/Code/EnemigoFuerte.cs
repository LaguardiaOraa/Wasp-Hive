using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoFuerte : MonoBehaviour
{
    private float speed = 2f;
    private Vector2 direction;

    private AudioSource Aplayer;
    public AudioClip clip;

    void Start()
    {
        Aplayer = GetComponent<AudioSource>();
        float randomX = Random.Range(-1f, 1f);
        float randomY = Random.Range(-1f, 1f);
        direction = new Vector2(randomX, randomY).normalized;
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        Vector2 screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        if (transform.position.x > screenBounds.x || transform.position.x < -screenBounds.x)
        {
            direction.x = -direction.x;
        }
        if (transform.position.y > screenBounds.y || transform.position.y < -screenBounds.y)
        {
            direction.y = -direction.y;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemigo")
        {
            Aplayer.clip = clip;
            Aplayer.Play();
        }
    }
}
