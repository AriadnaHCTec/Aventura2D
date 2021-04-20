using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Codigo que detecta coliders para activar platica
con Mama y platica con ingeniero.
Codigo que detecta una colision con jugador y activa
el dialogo entre Kathleen y el jugador

Autor: Miguel Ángel Pérez López
*/

public class PisoRefugio2 : MonoBehaviour
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
