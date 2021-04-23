using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Personaje
{
    public int vidas;
    public int monedas;
    public int nivel;
    public int preguntasCorrectasTotal;
    public int preguntasCorrectasEdif1;
    public int preguntasCorrectasJungla;
    public int preguntasCorrectasCueva;
    public int preguntasCorrectasEdif2;

    public Personaje(SaludPersonaje saludPersonaje){
        vidas = saludPersonaje.vidas;
        monedas = saludPersonaje.monedas;
        nivel = saludPersonaje.nivel;
        preguntasCorrectasTotal = saludPersonaje.preguntasCorrectasTotal;
        preguntasCorrectasEdif1 = saludPersonaje.preguntasCorrectasEdif1;
        preguntasCorrectasJungla = saludPersonaje.preguntasCorrectasJungla;
        preguntasCorrectasCueva = saludPersonaje.preguntasCorrectasCueva;
        preguntasCorrectasEdif2 = saludPersonaje.preguntasCorrectasEdif2;
    }

}
