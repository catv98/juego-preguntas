using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;

public class Adminsqlpre : MonoBehaviour {
    public string servidorBaseDatos;
    public string nombreBaseDatos;
    public string usuarioBaseDatos;
    public string contraseñaBaseDatos;
    string prueba;
    //public InputField ti;

    private string datosConexion;
    private MySqlConnection conexion;

    // Use this for initialization
    void Start()
    {
        datosConexion = "Server=" + servidorBaseDatos
            + ";Database=" + nombreBaseDatos
            + ";Uid=" + usuarioBaseDatos
            + ";Pwd=" + contraseñaBaseDatos
            + ";";
        conectarservidor();


    }

    private void conectarservidor()
    {
        //Debug.Log("si entra");
        conexion = new MySqlConnection(datosConexion);
        try
        {
            conexion.Open();
            Debug.Log("se establecio conexion");

        }
        catch (MySqlException err)
        {
            Debug.Log("no se pudo conectar: " + err);
        }
    }
   /* public MySqlDataReader Select(string _select)
    {
        
        MySqlCommand cmd = conexion.CreateCommand();
        cmd.CommandText = "INSERT INTO" + _select;
        //MySqlDataReader Resultado = cmd.
        return Resultado;

    }*/
    
    // Use this for initialization
    
	
	// Update is called once per frame
	void Update () {
		
	}
}
