using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyBar : MonoBehaviour
{
    Image barraDificultad;
    float maxDificultad = 100f;
    public static float dificultad;

    void Start()
    {
        barraDificultad = GetComponent<Image>();
        dificultad = maxDificultad;
    }

    void Update()
    {
        barraDificultad.fillAmount = dificultad / maxDificultad;
    }
}
