using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class preguntaActivar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CanvasDialogo;    
    public int indice;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //activar canvas dialogo
            CanvasDialogo.SetActive(true);
            Preguntas.instance.ActualizarCanvas(indice);
            print(indice);
        }
    }
}
