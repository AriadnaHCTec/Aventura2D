using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Detecta la colisi�n de la moneda con el personaje
 * Autor: Sara
 */
public class Moneda : MonoBehaviour
{
    
    // La moneda colision� con otro objeto (colliders)
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Recolectar
            // Reproducir un efecto de sonido
   
            // Dejar de dibujar a moneda
            GetComponent<SpriteRenderer>().enabled = false;
            // Prender la explosi�n
            // moneda.transform.hijo del transform(transform de la explosion).explosion.Se hace activa
            //gameObject.transform.GetChild(0).gameObject.SetActive(true);

            Destroy(gameObject, 0.5f);

            SaludPersonaje.instance.monedas += 25;
            HUD.instance.ActualizarMonedas();
        }
    }
}