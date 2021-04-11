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

    //Solicitar pausa/quitar pausa
    public void Pausar(){
        estaPausado = !estaPausado;

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

    //Sale del juego y regresa al menu principal
    public void SalirDelJuego(){

        //Código para guardar información

        //Cambiar a escena principal
        SceneManager.LoadScene("MenuPrincipal");

    }
}
