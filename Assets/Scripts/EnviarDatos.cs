using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking; // para red, UnityWebRequest
using Newtonsoft.Json; //JsonConvert
using UnityEngine.SceneManagement;

/*
Muestra el uso de UnityWebRequest para comunicarse con un servidor en la red.
Envia datos de la partida a la base de datos.
Miguel Ángel Pérez López
*/

public class EnviarDatos : MonoBehaviour
{
    //Encapsular los datos para convertir f�cilmente a JSON
    public struct DatosPartida
    {
        public string UsuarioUsuario;
        public string NivelNumNivel;
        public int vidas;
        public int preguntas;
        public int intentoPreguntas;
        public int puntos;
        public string horaInicioInicioSesion;
        public string horaFinalInicioSesion;
    }
    public DatosPartida datos;
    public static EnviarDatos instance;


    private void Awake()
    {
        instance = this;
    }

    
    public void EscribirJson() //Bot�n
    {
        //Concurrente
        StartCoroutine(SubirJson());
    }


    //Parte de este c�digo se ejecuta en paralelo
    private IEnumerator SubirJson()
    {
        var currentScene = SceneManager.GetActiveScene();
        var currentSceneName = currentScene.name;
        string pathRelativo = Application.persistentDataPath + "/usuario.txt";
        string texto = System.IO.File.ReadAllText(pathRelativo);

        string pathRelativo2 = Application.persistentDataPath + "/horaInicio.txt";
        string horaInicio = System.IO.File.ReadAllText(pathRelativo2);

        datos.UsuarioUsuario = texto;//Menu.instance.usuarioTexto.text;
        datos.NivelNumNivel = currentSceneName;
        datos.vidas = SaludPersonaje.instance.vidas;
        datos.preguntas = SaludPersonaje.instance.SumarPreguntasTotales();
        datos.intentoPreguntas = SaludPersonaje.instance.intentoPreguntas;
        datos.puntos = SaludPersonaje.instance.monedas;
        datos.horaInicioInicioSesion = horaInicio;
        datos.horaFinalInicioSesion = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        WWWForm forma = new WWWForm();
        forma.AddField("UsuarioUsuario", datos.UsuarioUsuario);
        forma.AddField("NivelNumNivel", datos.NivelNumNivel);
        forma.AddField("vidas", datos.vidas);
        forma.AddField("preguntas", datos.preguntas);
        forma.AddField("intentoPreguntas", datos.intentoPreguntas);
        forma.AddField("puntos", datos.puntos);
        forma.AddField("fechaInicio", datos.horaInicioInicioSesion);
        forma.AddField("fechaFinal", datos.horaFinalInicioSesion);
        UnityWebRequest request = UnityWebRequest.Post("http://3.17.77.93:8080/usuario/agregarUsuarioNivel", forma);
        //Aqu� es la bifurcaci�n.
        yield return request.SendWebRequest(); //Regresa, ejecuta y espera
        // Ya regres�, se termin� de ejecutar.
    }
}
