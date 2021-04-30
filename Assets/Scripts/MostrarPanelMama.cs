using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 Mostrar el panel de la Mam�
Miguel �ngel P�rez L�pez
 */
public class MostrarPanelMama : MonoBehaviour
{
    public GameObject panelIrConMama;

    
    public void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            panelIrConMama.SetActive(true);
        }
    }
}
