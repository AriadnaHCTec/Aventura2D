using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using System.Threading.Tasks;
/*
 Menu Inicio de Sesion
Ariadna Huesca Coronado
 */
public class MenuInicioSesion : MonoBehaviour
{
    //public Text contraseña;
    public Text usuario;
    public Text resultado;
    public InputField contraseña;
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
        forma.AddField("nombreUsuario", usuario.text);
        forma.AddField("contraseñaUsuario", contraseña.text);
        //print(contraseña.text)
        UnityWebRequest request = UnityWebRequest.Post("http://3.17.77.93:8080/usuario/iniciarSesion", forma);
        //Aqu� es la bifurcaci�n.
        yield return request.SendWebRequest(); //Regresa, ejecuta y espera
        // Ya regres�, se termin� de ejecutar.
        if (request.result == UnityWebRequest.Result.Success) // 200
        {
            string textoPlano = request.downloadHandler.text;
            if(textoPlano == "osiosi")
            {
                //Guardar nombre de usuario en un txt para poder accederlo en otros códigos
                string path = Application.persistentDataPath + "/usuario.txt";
                System.IO.File.WriteAllText (path, usuario.text);

                string path2 = Application.persistentDataPath + "/horaInicio.txt";
                inicioSesion = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                System.IO.File.WriteAllText (path2, inicioSesion);
                
                print("osiois");
                
                //Cargar el nivel donde se quedo el jugador si es que ya había jugado
                if(PlayerPrefs.HasKey(usuario.text + "Nivel")){
                    string nivel = PlayerPrefs.GetString(usuario.text + "Nivel");
                    SceneManager.LoadScene(nivel);
                }else{
                    SceneManager.LoadScene("Refugio");
                }
            }
            else
            {
                resultado.text = textoPlano;
                print("onono");
            }
        }
        else
        {
            resultado.text = "Error de inicio de sesion: " + request.responseCode.ToString();
        }
    }


}
