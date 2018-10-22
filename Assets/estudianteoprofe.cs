using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class estudianteoprofe : MonoBehaviour {

    public void escenainiciosesion()
    {
        SceneManager.LoadScene("escena inicio sesion");
    }

    public void volverdeinicioaeleccion()
    {
        SceneManager.LoadScene("Escena inicio");
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   
}
