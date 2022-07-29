using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionEnemy : MonoBehaviour
{

    public static int tic = 0;
    public static Vector3 hola;
    public int tikk = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PositionEnemy.tic == 1){

            Vector3 pos = transform.position; 
            //Debug.Log(transform.position.x+"  "+transform.position.y);
            LifeSoldier.pocision = pos;

            LifeSoldier.ticc= tikk;   
        }
        PositionEnemy.tic = 0;
        //Debug.Log(PositionEnemy.tic);
    }
}
