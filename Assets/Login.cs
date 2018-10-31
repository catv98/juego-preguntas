using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using MySql.Data.MySqlClient;

public class Login : MonoBehaviour {

    //public static GameControl control;
    public InputField id;
    public InputField contraseña;
    public static string idsa;
    public static string Nombre;
    public static string Grado;
    public GameObject textos;


    public void logear()
    {
        string _log = "`estudiantes` WHERE `id` LIKE '" + id.text+"'";
        Adminsql _adminsql = GameObject.Find("GameObject").GetComponent<Adminsql>();
        MySqlDataReader Resultado = _adminsql.Select(_log);

        Resultado.Read();

        
        var ids = Resultado.GetString(0);
        var nombre = Resultado.GetString(1);
        var grado = Resultado.GetString(11);

        idsa = ids;
        Nombre = nombre;
        Grado = grado;

        //Debug.Log(idsa);
        //Debug.Log(Nombre);
        //Debug.Log(Grado);

        textos.SetActive(true);

        if (Resultado.HasRows)
        {
            
            Debug.Log("Login correcto");
            Resultado.Close();
            Debug.Log(Resultado);
            SceneManager.LoadScene("escena home");
            
        }
        else {
            Debug.Log("No hay un usuario con este ID");
            Resultado.Close();
        }

    }

    

    public void logearprofe()
    {
        string _log = "`profesora` WHERE `id` LIKE '" + id.text + "' AND `contraseña` LIKE '" + contraseña.text+"'";
        Adminsql _adminsql = GameObject.Find("GameObject").GetComponent<Adminsql>();
        MySqlDataReader Resultado = _adminsql.Select(_log);


        if (Resultado.HasRows)
        {
            Debug.Log("Login correcto");
            Resultado.Close();
            Debug.Log(Resultado);
            SceneManager.LoadScene("escena homeprofe");
        }
        else
        {
            Debug.Log("No hay un usuario con este ID y contraseña");
            Resultado.Close();
        }
    }
    
        
    

    // Use this for initialization
    void Start () {
		
	}
    

    // Update is called once per frame
    void Update () {
		
	}
}
