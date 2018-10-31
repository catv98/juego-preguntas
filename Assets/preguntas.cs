using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;
using UnityEngine.UI;

public class preguntas : MonoBehaviour {
    int numerorandom;
    public Text textoP;
    public Text textoopciona;
    public Text textoopcionb;
    public Text textoopcionc;
    public Button a;
    public Button b;
    public Button c;
    //public bool variable;
    public Text PuntajeT;
    public int Puntaje=0;
    public int valorcorrecto;
     int valora;
     int valorb;
     int valorc;
    string correctaS;
    string opcionaS;
    string opcionbS;
    string opcioncS;
    int randomv;
    private MySqlConnection conexion;
    public string servidorBaseDatos;
    public string nombreBaseDatos;
    public string usuarioBaseDatos;
    public string contraseñaBaseDatos;
    private string datosConexion;

    //var datos;

    
    public void contarpreguntas()
    {
        string query = "SELECT count(*) from preguntas";

        MySqlCommand cmd = conexion.CreateCommand();
        cmd.CommandText = query;
        cmd.ExecuteNonQuery();
        Adminsql _adminsql = GameObject.Find("AdminDB").GetComponent<Adminsql>();
        MySqlDataReader Resultado = _adminsql.Select(query);

        Resultado.Read();
        var r = Resultado.GetString(0);
        //randomv =r
        Debug.Log(r);
    }

    public void preguntaaleatoria()
    {
        
        numerorandom = Random.Range(1,5);
        string _log = "`preguntas` WHERE `id` LIKE '" + numerorandom + "'";
        Adminsql _adminsql = GameObject.Find("AdminDB").GetComponent<Adminsql>();
        MySqlDataReader Resultado = _adminsql.Select(_log);


        Resultado.Read();
        
            var pregunta = Resultado.GetString(1);
            var opciona = Resultado.GetString(2);
            var opcionb = Resultado.GetString(3);
            var opcionc = Resultado.GetString(4);
            var correcta = Resultado.GetString(5);
            //Debug.Log(pregunta);
            //texto = datos.
            textoP.text = pregunta;
            textoopciona.text = opciona;
            textoopcionb.text = opcionb;
            textoopcionc.text = opcionc;
        correctaS = correcta;
        opcionaS = opciona;
        opcionbS = opcionb;
        opcioncS = opcionc;
            //a.Equals(textoopciona);


        
        
        
        
        /*
        if (opciona == correcta)
            {
                Debug.Log("es la a");
                valorcorrecto = 1;
            if (valora == valorcorrecto)
            {
                Puntaje++;
            }

        }
            else if (opcionb == correcta)
            {
                Debug.Log("es la b");
                valorcorrecto = 2;

            if (valora == valorcorrecto)
            {
                Puntaje++;
            }
        }
            else if (opcionc == correcta)
            {
                Debug.Log("es la c");
                valorcorrecto = 3;

            if (valora == valorcorrecto)
            {
                Puntaje++;
            }
        }
            else {
                Debug.Log("Hay un error con la pregunta");
                    }
        
        //botona();
        //botonb();
        //botonc();
        */
        if (Resultado.HasRows)
        {
            
            Resultado.Close();
      
        }
        else
        {
            Debug.Log("No hay pregunta con este id");
            Resultado.Close();
        }

        
        
        

    }
    public void botona()
    {
        valora = 1;
        Debug.Log("presiono boton a");
        if (valora == 1 && opcionaS == correctaS)
        {

            Puntaje += 1;
            Debug.Log(Puntaje);
        }
        else { Debug.Log("no sumó"); }

    }
    public void botonb()
    {
        valora = 2;
        Debug.Log("presiono boton b");
        if (valora == 2 && opcionbS == correctaS)
        {
            Puntaje += 1;
            Debug.Log(Puntaje);
        }
        else { Debug.Log("no sumó"); }
    }
    public void botonc()
    {
        valora = 3;
        Debug.Log("presiono boton c");
        if (valora == 3 && opcioncS == correctaS)
        {
            Puntaje += 1;
            Debug.Log(Puntaje);
        }
        else { Debug.Log("no sumó"); }
    }





    // Use this for initialization
    void Start () {
        datosConexion = "Server=" + servidorBaseDatos
            + ";Database=" + nombreBaseDatos
            + ";Uid=" + usuarioBaseDatos
            + ";Pwd=" + contraseñaBaseDatos
            + ";";
        conectarservidor();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void conectarservidor()
    {
        Debug.Log("si entra");
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
    public MySqlDataReader Select(string _select)
    {
        MySqlCommand cmd = conexion.CreateCommand();
        cmd.CommandText = "SELECT * FROM" + _select;
        MySqlDataReader Resultado = cmd.ExecuteReader();
        return Resultado;

    }
}
