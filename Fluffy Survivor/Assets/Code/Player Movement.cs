using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject usuario;
    private AudioSource Aplayer;
    public AudioClip[] clip;

    void Start()
    {
        Aplayer = GetComponent<AudioSource>();
    }

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.z = 0;
        transform.position = mousePos;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            Aplayer.clip = clip[0];
            Aplayer.Play();
            HealthController.salud -= 1;
            StartCoroutine(Invencivilidad());
        }
        if (collision.gameObject.CompareTag("Cura"))
        {
            Aplayer.clip = clip[1];
            Aplayer.Play();
        }
    }

    IEnumerator Invencivilidad()
    {
        GetComponent<Collider2D>().enabled = false;
        GetComponent<SpriteRenderer>().color = Color.green;
        yield return new WaitForSeconds(5);
        GetComponent<SpriteRenderer>().color = Color.white;
        GetComponent<Collider2D>().enabled = true;
    }
}
