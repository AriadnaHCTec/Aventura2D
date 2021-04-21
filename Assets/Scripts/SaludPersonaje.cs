using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaludPersonaje : MonoBehaviour
{
    public int vidas = 4;
    public int monedas = 0;
    public float posicionX = 0;
    public float posicionY = 0;
    public bool platicaMama1 = false;

    public static SaludPersonaje instance;

    private void Awake(){
        instance = this; //this es un apuntador al objeto que esta ejecutando el código
    }

}
