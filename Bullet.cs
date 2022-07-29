using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{

    public GameObject hitEffect;

    public int contVidaEnemy; // esto es para ver si los enemigo duran mas

    public AudioSource m_ExplosionAudio;
    public AudioClip m_BoomClip;

    public int sumaScore = 1;
    
    public int tik = 1;
    //variable swict de aqui para vida 
    public bool switche = false;

    

    void OnCollisionEnter2D(Collision2D collision)
    {
        //m_ExplosionAudio.clip = m_BoomClip;
        //m_ExplosionAudio.Play ();
        SonidoExplosion.encender = true;

        if (collision.gameObject.CompareTag("Enemy1"))
        {
            ScoreEnemy.contador +=sumaScore;
            Shooting.var +=sumaScore;

            PositionEnemy.tic = tik; 

            Destroy(collision.gameObject);

            //si la bala colisiona con el enemigo me generara la vida donde murio el enemigo
            //collision.gameObject.GetComponent<Shooting>().hola = 10;
            switche = true;
            //collision.gameObject.SetActive (false);
        }
        //tik = 0;
        //PositionEnemy.tic = tik;
            //setTextoContador();
        
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.5f);
        Destroy(gameObject);

        if(switche == true)
        {
            //si la bala colisiona con el enemigo me generara la vida donde murio el enemigo
            //collision.gameObject.GetComponent<LifeSoldier>().Switch = 1;
        }
        

        
    }

    // Start is called before the first frame update
    void Start()
    {
        
        //switche = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    

}
