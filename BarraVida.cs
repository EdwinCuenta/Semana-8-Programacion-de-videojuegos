using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{

    public Image vida;

    public float vidaActual;
    public float vidaMaxima;
    public float vidaTotal;
    public int reducir = 0;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        vida.fillAmount = vidaActual / vidaMaxima;
        vidaTotal = vidaActual; 
        if(vidaTotal == 0)
            reducir = 1;  
    }

    
}
