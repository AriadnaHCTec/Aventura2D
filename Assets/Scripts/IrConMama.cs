using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
