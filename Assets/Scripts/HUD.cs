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


    private void Start(){
        //Leer el valor desde las preferencias
        int numeroMonedas = PlayerPrefs.GetInt("numeroMonedas",0);
        SaludPersonaje.instance.CargarInfo();
        textoMonedas.text = SaludPersonaje.instance.monedas.ToString();
        SaludPersonaje.instance.monedas = numeroMonedas;
    }


    public void ActualizarVidas(){
        int vidas = SaludPersonaje.instance.RegresarVidas();
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


    public void ActualizarMonedas(){
        SaludPersonaje.instance.CargarInfo();
        textoMonedas.text = SaludPersonaje.instance.monedas.ToString();
    }

}
