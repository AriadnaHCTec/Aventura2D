using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 Activa la interacci�n con el elevador cuando hizo la misi�n
Miguel �ngel P�rez L�pez
 */
public class IrConMama : MonoBehaviour
{
    public GameObject elevador;

    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Player")){
            //activar dialogo
            elevador.SetActive(true);
        }
    }
}
