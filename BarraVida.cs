using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{

    public Image vida;

    public static float vidaActual = 100;
    public float vidaMaxima;
    public static float vidaTotal;
    public static int reducir;

    

    // Start is called before the first frame update
    void Start()
    {
        vidaActual = 100;
        ScoreEnemy.contador = 0;
    }


    // Update is called once per frame
    void Update()
    {   //Debug.Log("reducir:  "+BarraVida.reducir);
        if(BarraVida.vidaActual >100)
        {
            BarraVida.vidaActual = 100;
        }
        vida.fillAmount = BarraVida.vidaActual / vidaMaxima;
         
    }

    
}
