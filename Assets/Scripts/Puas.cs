using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Sarahi Armenta */

public class Puas : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject, t: 1);
        }
        
    }
}
