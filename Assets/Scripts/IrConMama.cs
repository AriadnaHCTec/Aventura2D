using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrConMama : MonoBehaviour
{
    public GameObject controlIrConMama;

    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Player")){
            //activar canvas dialogo
            controlIrConMama.SetActive(true);
        }
        //Guardar que el jugador ya platico con el ingeniero
        PlayerPrefs.SetInt("platicaConIngeniero",1);
    }
}
