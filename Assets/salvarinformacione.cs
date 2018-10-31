using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class salvarinformacione : MonoBehaviour {

    public static string sName;
    public static string sid;
    public static string sgrado;
    //Text Name;
    //Text identification;
    //Text Grd;


    
    

	// Use this for initialization
	void Start () {
        

        Debug.Log(sName);
    }
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }


    // Update is called once per frame
    void Update () {
        sid = Login.idsa;
        sName = Login.Nombre;
        sgrado = Login.Grado;
    }
}
