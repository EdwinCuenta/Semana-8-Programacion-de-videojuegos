using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{

    public AudioSource m_ShootingAudio;  
    public AudioClip m_FireClip; 

    
    void Start()
    {
        m_ShootingAudio.clip = m_FireClip;
        m_ShootingAudio.Play ();
    }
    public void jugar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void salir()
    {
        Debug.Log("Salir..");
        Application.Quit();
    }

    public void volverMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    
}
