using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSoldier : MonoBehaviour
{

    public GameObject SoldierLife;
    //public float RangoCreacion = 2f;

    public int pruebaa = 25;
    public int Switch = 0;
    public static Vector3 pocision;
    public static int ticc;
    public float x,y,z;

    public float a = 5f, b = 5f , c=0f;
    public string equiz, ye, zeta;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(SoldierLife, new Vector3 (-11,5,0), SoldierLife.transform.rotation);
        
        //Debug.Log(LifeSoldier.pocision.x +"  "+LifeSoldier.pocision.y);
        //Instantiate(SoldierLife, new Vector3 (LifeSoldier.pocision.x,LifeSoldier.pocision.y,LifeSoldier.pocision.z), SoldierLife.transform.rotation);
        //InvokeRepeating("Generar", 3.0f,3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(LifeSoldier.ticc == 1)
        {
            equiz = LifeSoldier.pocision.x.ToString();
            ye = LifeSoldier.pocision.y.ToString();
            zeta = LifeSoldier.pocision.z.ToString();
            /*
            int.TryParse(equiz, out x);
            int.TryParse(ye, out y);
            int.TryParse(zeta, out z);
            */

            x = float.Parse(equiz);
            y = float.Parse(ye);
            z = float.Parse(zeta);

            
            
            Instantiate(SoldierLife, new Vector3 (x,y,z), SoldierLife.transform.rotation);
            Debug.Log(LifeSoldier.pocision.x +"  "+LifeSoldier.pocision.y);
            Debug.Log(x +"  "+y);
            Debug.Log(x + y);
            a++;
            b++;
            c++;
        }
        LifeSoldier.ticc = 0;

    }
    /*
    void Generar()
    {
        //BarraVida.reducir = pruebaa;
        Vector3 SpawnPosition = new Vector3 (19,3,0);
        SpawnPosition = this.transform.position + Random.onUnitSphere * RangoCreacion;
        SpawnPosition = new Vector3 (SpawnPosition.x, SpawnPosition.y, 0);

        GameObject Life = Instantiate (SoldierLife, SpawnPosition, Quaternion.identity);
    }
    */
}
