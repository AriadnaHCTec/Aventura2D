using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    private bool estaPausado; //true->esta en pausa
    public GameObject pantallaPausa; //Panel obscuro que creamos en unity
    //pusimos gameobject en vez de panel
    //se pone como object para que pueda funcionar con más cosas como canvas, panel, etc
    public GameObject pantallaConfirmacion;
    public bool ConfirmarSalir;//va a empezar en false
    //public GameObject HUD;
    //public bool estadoHUD;

    //Solicitar pausa/quitar pausa
    public void Pausar(){
        estaPausado = !estaPausado;

        //HUD.SetActive(!estadoHUD);
        //prende o apaga la pantalla
        pantallaPausa.SetActive(estaPausado);

        //escala de tiempo
        Time.timeScale = estaPausado ? 0 : 1;//si pausado es true, se para el tiempo sino se continua el tiempo
        
        //codigo para alentar el juego
        //Time.timeScale = estaPausado ? 0.3f : 1;
    }

    // Update is called once per frame
    void Update()
    {
        //si el usuario clickeo en la tecla escape se pausa
        if(Input.GetKeyDown(KeyCode.Escape)){
            Pausar();
        }
    }


    public void IrAMenuSalirDelJuego(){
        //Cambiar a escena donde se pregunta al usuario que confirme que desea salir o continuar
        pantallaPausa.SetActive(false);
        pantallaConfirmacion.SetActive(true);
    }


    public void RegresarAMenuPausa(){
        //Metodo que se asigna al boton de "no" y regresa al menu de pausa
        pantallaConfirmacion.SetActive(false);
        pantallaPausa.SetActive(true);
    }

    public void SalirDelJuego(){
        //Código para guardar información

        //Ir a menu principal
        SceneManager.LoadScene("MenuPrincipal");  
    }
}
