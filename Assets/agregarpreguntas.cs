using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;
using UnityEngine.UI;

public class agregarpreguntas : MonoBehaviour {
    //public InputField id;
    public InputField pregunta;
    public InputField opcioa;
    public InputField opcionb;
    public InputField opcionc;
    public InputField respuesta;
    private MySqlConnection conexion;
    public string servidorBaseDatos;
    public string nombreBaseDatos;
    public string usuarioBaseDatos;
    public string contraseñaBaseDatos;
    private string datosConexion;


    // Use this for initialization
    public void agregarpreguntass()
    {

        string query = "INSERT INTO `preguntas` (`id`,`pregunta`,`Popcion`,`Sopcion`,`Topcion`,`Correcta`) VALUES ('NULL'" + "," + "'" + pregunta.text + "'" + "," + "'" + opcioa.text + "'" + "," + "'" + opcionb.text + "'" + "," + "'" + opcionc.text + "'" + "," + "'" + respuesta.text + "'" + ")";
        
        MySqlCommand cmd = conexion.CreateCommand();
        cmd.CommandText = query;
        cmd.ExecuteNonQuery();
        //Bind();
        //cmd.CommandText = "INSERT INTO `preguntas` (`id`,`pregunta`,`Popcion`,`Sopcion`,`Topcion`,`Correcta`) VALUES ('" + id.text + "'" + "," + "'" + id.text + "'" + "," + "'" + pregunta.text + "'" + "," + "'" + opcioa.text + "'" + "," + "'" + opcionb.text + "'" + "," + "'" + opcionb.text + "'" + "," + "'" + opcionc.text + "'" + "," + "'" + respuesta.text + "'" + ")";
        //string _log = 
        
    }
    
    void Start () {
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

    // Update is called once per frame
    void Update () {
		
	}
}
