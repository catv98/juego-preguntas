using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movimientointerfaz : MonoBehaviour {


    public void mhome()
    {
        SceneManager.LoadScene("escena home");
    }

    public void mjuego()
    {
        SceneManager.LoadScene("escena juegos");
    }
    public void mestadistica()
    {
        SceneManager.LoadScene("escena estadisticas");

    }
    public void manalisis()
    {
        SceneManager.LoadScene("escena analisis");

    }
    public void iniprofe()
    {
        SceneManager.LoadScene("escena inicioprofe");
    }

    public void mhomeprofe()
    {
        SceneManager.LoadScene("escena homeprofe");
    }

    public void profepregutas()
    {
        SceneManager.LoadScene("escena preguntaprofe");
    }
    public void agregarpreguntas()
    {
        SceneManager.LoadScene("escena agregarpre");
    }

   
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
