using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Codigo que detecta coliders para activar platica
con Kathleen.

Autor: Miguel Ángel Pérez López
*/

public class PisoCueva : MonoBehaviour
{
    public GameObject CanvasDialogo;
    public GameObject DialogManager;

    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Player")){
            //activar canvas dialogo
            CanvasDialogo.SetActive(true);
            DialogManager.SetActive(true);
        }
    }
}