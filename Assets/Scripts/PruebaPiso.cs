using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 *Ariadna Huesca Coronado
 *Código que tiene un estado estaEnPiso(booleano)
*/
public class PruebaPiso : MonoBehaviour
{
    // atributo más importante
    public static bool estaEnPiso=false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Tambien other.gameObject.tag!=Tag
        if (!other.gameObject.CompareTag("Moneda"))
        {
            estaEnPiso = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        estaEnPiso = false;        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
