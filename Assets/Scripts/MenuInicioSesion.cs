using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 Menu Inicio de Sesion
Ariadna Huesca Coronado
 */
public class MenuInicioSesion : MonoBehaviour
{
    public Text password;
    public Text usuarioTexto;
    public Text resultado;
    public string inicioSesion;
    public static MenuInicioSesion instance;

    public void Awake()
    {
        instance = this;
    }
    public void IniciarSesion()
    {
        resultado.text = usuarioTexto.text;
        inicioSesion = DateTime.Now.ToString().Substring(11, 8);
        // CAMBIAR escena
        SceneManager.LoadScene("EscenaMapa");
    }
}
