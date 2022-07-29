using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarEnemy : MonoBehaviour
{

    public GameObject Enemys;

    public float RangoCreacion = 2f;

    //private float posGenerarEnemysZ = 5.89f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Generar", 2.0f,2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Generar()
    {
        Vector3 SpawnPosition = new Vector3 (0,0,0);
        SpawnPosition = this.transform.position + Random.onUnitSphere * RangoCreacion;
        SpawnPosition = new Vector3 (SpawnPosition.x, SpawnPosition.y, 0);

        GameObject Enemy = Instantiate (Enemys, SpawnPosition, Quaternion.identity);
    }
}
