using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyBar : MonoBehaviour
{
    Image barraDificultad;
    float maxDificultad = 100f;
    public static float dificultad;
    // Start is called before the first frame update
    void Start()
    {
        barraDificultad = GetComponent<Image>();
        dificultad = maxDificultad;
    }

    // Update is called once per frame
    void Update()
    {
        barraDificultad.fillAmount = dificultad/maxDificultad;
    }
}
