using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 Menu Inicio de Sesion
Ariadna Huesca Coronado
 */
public class MenuInicioSesion : MonoBehaviour
{
    public Text contraseña;
    public Text usuario;
    public Text resultado;
    public string inicioSesion;
    public static MenuInicioSesion instance;

    public void Awake()
    {
        instance = this;
    }
    

    public void EscribirJsonInicioSesion() //Bot�n
    {
        //Concurrente
        StartCoroutine(SubirJson());
    }

    //Parte de este c�digo se ejecuta en paralelo
    private IEnumerator SubirJson()
    {                
        WWWForm forma = new WWWForm();
        forma.AddField("usuario", usuario.text);
        forma.AddField("contraseña", contraseña.text);
        UnityWebRequest request = UnityWebRequest.Post("http://localhost:8080/usuario/iniciarSesion", forma);
        //Aqu� es la bifurcaci�n.
        yield return request.SendWebRequest(); //Regresa, ejecuta y espera
        // Ya regres�, se termin� de ejecutar.
        if (request.result == UnityWebRequest.Result.Success) // 200
        {
            string textoPlano = request.downloadHandler.text;
            if(textoPlano == "osiosi")
            {
                PlayerPrefs.SetString("usuario", usuario.text);
                PlayerPrefs.Save();
                SceneManager.LoadScene("Refugio");                
            }
            else
            {
                resultado.text = textoPlano;
            }
        }
        else
        {
            resultado.text = "Error de inicio de sesion: " + request.responseCode.ToString();
        }
    }


}
