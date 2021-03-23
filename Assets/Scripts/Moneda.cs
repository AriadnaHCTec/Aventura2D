/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    // La moneda colisionó con otro objeto (collider)
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Apagar moneda
            GetComponent<SpriteRenderer>().enabled = false;

            //prender explosión
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            // Destruir el gameObject despues de .5 segundos
            Destroy(gameObject, .5f);
        }
    }
}
*/