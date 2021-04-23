using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaludPersonaje : MonoBehaviour
{
    public int vidas = 4;
    public int monedas = 0;
    public int nivel=1;
    public int preguntasCorrectasTotal=0;
    public int preguntasCorrectasEdif1=0;
    public int preguntasCorrectasJungla=0;
    public int preguntasCorrectasCueva=0;
    public int preguntasCorrectasEdif2=0;
    public static SaludPersonaje instance;

    private void Awake(){
        instance = this; //this es un apuntador al objeto que esta ejecutando el código
    }


    public void GuardarInfo(){
        GuardarDatos.GuardarInfo(this);
    }

    public void CargarInfo(){
        Personaje data = GuardarDatos.CargarInfo();
        vidas = data.vidas;
        monedas = data.monedas;
        nivel = data.nivel;
        preguntasCorrectasTotal = data.preguntasCorrectasTotal;
        preguntasCorrectasEdif1 = data.preguntasCorrectasEdif1;
        preguntasCorrectasJungla = data.preguntasCorrectasJungla;
        preguntasCorrectasCueva = data.preguntasCorrectasCueva;
        preguntasCorrectasEdif2 = data.preguntasCorrectasEdif1;
    }    


    public void AumentarMonedas(){
        CargarInfo();
        monedas +=25;
        GuardarInfo();
    }


    public void RestarVida(){
        CargarInfo();
        vidas -=1;
        GuardarInfo();
    }


    public void PersonajeMuere(int nivell){
        CargarInfo();
        monedas = 0;
        nivel = nivell;
        GuardarInfo();
    }


    public int RegresarVidas(){
        CargarInfo();
        return vidas;
    }
}
