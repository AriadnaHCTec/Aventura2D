using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMuere : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Enemigo"))
        {            
            // Dejar de dibujar a moneda
            GetComponent<SpriteRenderer>().enabled = false;
            // Prender la explosión
            // moneda.transform.hijo del transform(transform de la explosion).explosion.Se hace activa
            gameObject.transform.GetChild(2).gameObject.SetActive(true);

            Destroy(gameObject, 0.5f);
        }
    }
}
