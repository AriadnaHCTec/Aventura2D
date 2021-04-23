using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 Animaci�n activada cuando el personaje se muera.
 */
public class CMuere : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rigidbody;      // Para f�sica
    void Start()
    {
        // Inicializar variables
        rigidbody = GetComponent<Rigidbody2D>();    // Enlazar RB -> script
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        rigidbody = GetComponent<Rigidbody2D>();    // Enlazar RB -> script
        if (other.gameObject.CompareTag("Enemigo") && SaludPersonaje.instance.RegresarVidas() <= 0)
        {            
            // Dejar de dibujar a moneda
            GetComponent<SpriteRenderer>().enabled = false;
            rigidbody.constraints = RigidbodyConstraints2D.FreezePosition;
            //rigidbody.velocity = new Vector2(0, 0);
            // Prender la explosi�n
            // moneda.transform.hijo del transform(transform de la explosion).explosion.Se hace activa
            gameObject.transform.GetChild(2).gameObject.SetActive(true);            

            Destroy(gameObject, 0.5f);
        }
    }
}
