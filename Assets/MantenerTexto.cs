using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MantenerTexto : MonoBehaviour {
    public Text identificacion;
    public Text NOMBRE;
    public Text GRADO;

	// Use this for initialization
	void Start () {
        

        //Debug.Log(salvarinformacione.sid);

		
	}
	
	// Update is called once per frame
	void Update () {
        identificacion.text = salvarinformacione.sid;
        NOMBRE.text = salvarinformacione.sName;
        GRADO.text = salvarinformacione.sgrado;
    }
}
