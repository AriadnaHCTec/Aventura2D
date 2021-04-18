using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
