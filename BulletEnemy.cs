using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletEnemy : MonoBehaviour
{

    public GameObject hitEffect;
    public bool danio;
    public int a = 10;

    void OnCollisionEnter2D(Collision2D collision)
    {
        SonidoExplosion.encenderEnemy = true;
        if (collision.gameObject.CompareTag("Soldier"))
        {   
            danio = true;
            BarraVida.vidaActual -= 10;
            //collision.gameObject.GetComponent<BarraVida>().reducir -= 10;
            
            if(BarraVida.vidaActual == 0 )
            {
                Destroy(collision.gameObject);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        danio = false;
        
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.5f);
        Destroy(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
