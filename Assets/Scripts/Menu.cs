using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text password;
    public Text usuarioTexto;
    //public Text resultado; a futuro sería el texto de error si el inicio de sesión está mal
    public string inicioSesion;
    public static Menu instance;
    public Image imagenFondo;


    public void Awake()
    {
        instance = this;
    }


    public void Salir()
    {
        // Regresa al Sistema Operativo
        Application.Quit();
    }
    

    public void IniciarJuego()
    {
        /*imagenFondo.canvasRenderer.SetAlpha(0);
        imagenFondo.gameObject.SetActive(true);
        imagenFondo.CrossFadeAlpha(1, .7f, true);*/
        // Cambiar de escena
        //resultado.text = usuarioTexto.text;
        inicioSesion = DateTime.Now.ToString().Substring(11, 8);

        //StartCoroutine(CambiarEscena());
        // CAMBIAR escena        
    }

    /*
    private IEnumerator CambiarEscena()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("EscenaMapa");
    }*/
}

