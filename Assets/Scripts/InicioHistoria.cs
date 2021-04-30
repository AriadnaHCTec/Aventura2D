using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Apaga el canvas para que inicie el juego.

Autor: Miguel Ángel Pérez López
*/


public class InicioHistoria : MonoBehaviour
{
    public GameObject CanvasDialogo;
    public GameObject DialogManager;
    public GameObject canvasHistoria;

    public void ClickBoton(){
        CanvasDialogo.SetActive(true);
        DialogManager.SetActive(true);
        canvasHistoria.SetActive(false);
    }
}
