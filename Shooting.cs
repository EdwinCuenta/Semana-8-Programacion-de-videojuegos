using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    public AudioSource m_ShootingAudio;
    public AudioClip m_FireClip;

    public AudioSource vidaSource;
    public AudioClip vidaClip;

    public Text VidaOn;
    public Text puntaje;

    public string score = "sumador";
    public int sumador;

    //prueba
    public static int var = 0;

    // Start is called before the first frame update
    
    public void Awake()
    {
        //LoadData();
    }

    void Start()
    {
        LoadData();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
            m_ShootingAudio.clip = m_FireClip;
            m_ShootingAudio.Play ();
        }
        if(Shooting.var != 0)
        {

            sumador = Shooting.var; 
        }
        
        if(Shooting.var >= 10)
            VidaOn.text = "On";
            
        if (Input.GetKeyUp("q"))
        {   
            //var++;
            //if (ScoreEnemy.conterVidaOn >= 10)
            //ScoreEnemy.cambio = true;
            if(Shooting.var >= 10){
                Debug.Log("presionado");
                BarraVida.vidaActual += 20;
                Shooting.var = 0;
                VidaOn.text = "Off";
                //var = 0;

                vidaSource.clip = vidaClip;
                vidaSource.Play ();
            }
        }

        //ScoreEnemy.cambio = false;
    }

    void Shoot()
    {
        GameObject bullet =  Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

        


    }

    public void OnDestroy()
    {
        SaveData();
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt(score, sumador );
    }

    public void LoadData(){
        sumador = PlayerPrefs.GetInt(score,0);
        puntaje.text = sumador.ToString();
    }
}
