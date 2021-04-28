using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 Pone en true el canvas cuando pasa por un collider
Ariadna Huesca Coronado
 */
public class ActivarPreguntas : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CanvasDialogo;    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //activar canvas dialogo
            CanvasDialogo.SetActive(true);
        }
    }
}

