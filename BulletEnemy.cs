using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{

    public GameObject hitEffect;
    public bool danio;
    public int a = 10;

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Soldier"))
        {   
            danio = true;
            collision.gameObject.GetComponent<BarraVida>().vidaActual -= 10;
            
            if(collision.gameObject.GetComponent<BarraVida>().vidaTotal == 0 )
            {
                Destroy(collision.gameObject);
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
