using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Sirve para asignar metodo a boton para cargar
canvas de preguntas
*/

public class CanvasExplicacion : MonoBehaviour
{
    public GameObject canvasPreguntas;
    public GameObject canvasActual;

    public void ClickBoton(){
        canvasPreguntas.SetActive(true);
        canvasActual.SetActive(false);
    }
}
