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
    public int Puntaje=-1;
    public int valorcorrecto;
     int valora;
     int valorb;
     int valorc;

    //var datos;


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
            //a.Equals(textoopciona);

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
        
    }
    public void botonb()
    {
        valora = 2;
        
    }
    public void botonc()
    {
        valora = 3;
        
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
