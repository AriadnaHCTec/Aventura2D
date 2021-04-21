using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 *Ariadna Huesca Coronado
 *C�digo que tiene un estado estaEnPiso(booleano)
*/

public class PruebaPiso : MonoBehaviour
{
    // atributo m�s importante
    public static bool estaEnPiso=false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Tambien other.gameObject.tag!=Tag
        if (!other.gameObject.CompareTag("Moneda") && !other.gameObject.CompareTag("fantasma") && !other.gameObject.CompareTag("IngenieroAnimacion") && !other.gameObject.CompareTag("elevador") && !other.gameObject.CompareTag("helicoptero"))
        {
            estaEnPiso = true;
        }/*else if(!other.gameObject.CompareTag("fantasma")){
            estaEnPiso = true;
        }else if(!other.gameObject.CompareTag("IngenieroAnimacion")){
            estaEnPiso=true;
        }else if(!other.gameObject.CompareTag("elevador")){
            estaEnPiso=true;
        }else if(!other.gameObject.CompareTag("helicoptero")){
            estaEnPiso=true;
        }*/
        else{
            estaEnPiso = false;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        estaEnPiso = false;        
    }
}
