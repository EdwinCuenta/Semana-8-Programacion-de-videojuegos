using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoExplosion : MonoBehaviour
{

    public AudioSource m_ExplosionAudio;
    public AudioClip m_BoomClip;

    public static bool encender = false;
    public static bool encenderEnemy = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SonidoExplosion.encender == true)
        {
            m_ExplosionAudio.clip = m_BoomClip;
            m_ExplosionAudio.Play ();
            SonidoExplosion.encender = false;
        }

        if(SonidoExplosion.encenderEnemy == true)
        {
            m_ExplosionAudio.clip = m_BoomClip;
            m_ExplosionAudio.Play ();
            SonidoExplosion.encenderEnemy = false;
        }
    }
}
