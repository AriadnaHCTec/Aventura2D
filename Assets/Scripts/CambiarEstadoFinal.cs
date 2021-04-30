using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking; // para red, UnityWebRequest
using Newtonsoft.Json; //JsonConvert
using UnityEngine.SceneManagement;

/*
 Envía un POST a la página para que actualice el estado del usuario a finalizad=true
Miguel Ángel Pérez López
 */
public class CambiarEstadoFinal : MonoBehaviour
{
    
    //Encapsular los datos para convertir f�cilmente a JSON
    public struct DatosPartida
    {
        public string nombreUsuario;
    }
    public DatosPartida datos;
    public static CambiarEstadoFinal instance;


    private void Awake()
    {
        instance = this;
    }

    
    public void EscribirJson2() //Bot�n
    {
        //Concurrente
        StartCoroutine(SubirJson2());
    }


    //Parte de este c�digo se ejecuta en paralelo
    private IEnumerator SubirJson2()
    {
        string pathRelativo = Application.persistentDataPath + "/usuario.txt";
        string texto = System.IO.File.ReadAllText(pathRelativo);
        datos.nombreUsuario = texto;//Menu.instance.usuarioTexto.text;
        WWWForm forma = new WWWForm();
        forma.AddField("nombreUsuario", datos.nombreUsuario);
        UnityWebRequest request = UnityWebRequest.Post("http://http://3.17.77.93:8080/usuario/UsuarioTermino", forma);
        //Aqu� es la bifurcaci�n.
        yield return request.SendWebRequest(); //Regresa, ejecuta y espera
        // Ya regres�, se termin� de ejecutar.
    }
}
