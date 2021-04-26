using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreguntaAct : MonoBehaviour
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
