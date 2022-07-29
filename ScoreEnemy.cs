using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreEnemy : MonoBehaviour
{

    public GameObject Enem;

    public Text ScorePoint;
    public static Text VidaOnn;

    public static int contador;
    public static bool cambio = false;
    public static int conterVidaOn;
    public int diez = 10;


    /*void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            BarraVida Shot =collision.gameObject.GetComponent<BarraVida>();
            if(Shot != null)
                collision.gameObject.GetComponent<BarraVida>().vidaActual -=10;
            contador++;
             setTextoContador();
        }
    }
    */
    // Start is called before the first frame update
    void Start()
    {
        //ScoreEnemy.VidaOnn.text = "";
        //ScoreEnemy.contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        setTextoContador();

        if(ScoreEnemy.contador >= 10)
        {
            ScoreEnemy.conterVidaOn++;
            //VidaOnn.text = "Off";
        }
            
        
        /*
        if (ScoreEnemy.cambio == true){
           

            if (ScoreEnemy.conterVidaOn >= 10){

                //VidaOnn.text = "On";
               Debug.Log("Sube vidaaaaaaa");
               //conterVidaOn =0;
               //VidaOnn.text = "On";
               ScoreEnemy.conterVidaOn = 0;
            }
            
        }
        ScoreEnemy.cambio = false;
        */
    }

    void setTextoContador(){
        
        ScorePoint.text = "Derrotados: " + ScoreEnemy.contador.ToString();
        //ScoreEnemy.conterVidaOn++;
        
        
        
        
    }
    
    void aciveLife()
    {
        if(conterVidaOn == 10)
        {
           conterVidaOn = 0;
               
           //BarraVida.vidaActual +=diez;
           Debug.Log("conuter: "+conterVidaOn);
        }
        
    }
}
