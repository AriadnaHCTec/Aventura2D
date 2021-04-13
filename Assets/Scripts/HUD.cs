using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//para imagen

public class HUD : MonoBehaviour
{
    public Image imagen1;
    public Image imagen2;
    public Image imagen3;
    public Image imagen4;
    public Text textoMonedas;

    public static HUD instance;


    private void Awake() {
        instance = this;    
    }


    public void ActualizarVidas(){
        int vidas = SaludPersonaje.instance.vidas;
        if(vidas == 3){
            imagen4.enabled = false;
        }else if(vidas == 2){
            imagen3.enabled = false;
        }else if(vidas == 1){
            imagen2.enabled = false;
        }else if(vidas == 0){
            imagen1.enabled = false;
        }
    }


    /*public void ActualizarMonedas(){
        textoMonedas.text = SaludPersonaje.instance.monedas.ToString();
    }*/

}
