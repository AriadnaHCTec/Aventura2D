using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Epilogo : MonoBehaviour
{
    /*public GameObject boton1;
    public GameObject boton2;
    public GameObject boton3;
    public GameObject texto1;
    public GameObject texto2;
    public GameObject texto3;*/
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;


    public void ClickBoton1(){
        canvas2.SetActive(true);
        canvas1.SetActive(false);
    }


    public void ClickBoton2(){
        canvas3.SetActive(true);
        canvas2.SetActive(false);
    }


    public void ClickBoton3(){
        Application.Quit();
    }
}
