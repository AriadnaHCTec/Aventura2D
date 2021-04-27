using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Se crea una clase para guardar varios
    atributos durante el juego. Este código
    permite que otros 2 scripts 
    (GuardarDatos, SaludPersonaje) funcionen.

    Autor: Miguel Ángel Pérez López
*/

[System.Serializable]
public class Personaje
{
    //public string nombreUsuario;
    public int vidas;
    public int monedas;
    public int monedasPorNivel;//estas monedas se guardan pero si el jugador muere en el nivel se borran
    public int nivel;
    public int preguntasCorrectasEdif1;
    public int preguntasCorrectasJungla;
    public int preguntasCorrectasCueva;
    public int preguntasCorrectasEdif2;
    public int preguntasCorrectasTotal;
    public int intentoPreguntas;
    public DateTime tiempoInicio;
    public DateTime tiempoFinal;
    public string tiempoTotal;


    public Personaje(SaludPersonaje saludPersonaje){
        //nombreUsuario = saludPersonaje.nombreUsuario;
        vidas = saludPersonaje.vidas;
        monedas = saludPersonaje.monedas;
        monedasPorNivel = saludPersonaje.monedasPorNivel;
        nivel = saludPersonaje.nivel;
        preguntasCorrectasTotal = saludPersonaje.preguntasCorrectasTotal;
        preguntasCorrectasEdif1 = saludPersonaje.preguntasCorrectasEdif1;
        preguntasCorrectasJungla = saludPersonaje.preguntasCorrectasJungla;
        preguntasCorrectasCueva = saludPersonaje.preguntasCorrectasCueva;
        preguntasCorrectasEdif2 = saludPersonaje.preguntasCorrectasEdif2;
        intentoPreguntas = saludPersonaje.intentoPreguntas;
        tiempoInicio = saludPersonaje.tiempoInicio;
        tiempoFinal = saludPersonaje.tiempoFinal;
        tiempoTotal = saludPersonaje.tiempoTotal;
    }

}
