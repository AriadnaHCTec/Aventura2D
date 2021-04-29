using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Epilogo : MonoBehaviour
{
    public GameObject boton1;
    public GameObject boton2;
    public GameObject boton3;
    public GameObject texto1;
    public GameObject texto2;
    public GameObject texto3;


    public void ClickBoton1(){
        boton2.SetActive(true);
        texto2.SetActive(true);
        boton1.SetActive(false);
        texto1.SetActive(false);
    }


    public void ClickBoton2(){
        boton3.SetActive(true);
        texto3.SetActive(true);
        boton2.SetActive(false);
        texto2.SetActive(false);
    }


    public void ClickBoton3(){
        Application.Quit();
    }
}
