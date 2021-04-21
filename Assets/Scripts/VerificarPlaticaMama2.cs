using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificarPlaticaMama2 : MonoBehaviour
{
    public GameObject barreraSalir;//barrera que prohibe salir del refugio
    public GameObject colliderPlatica;

    void Start(){
        int platicaIngeniero = PlayerPrefs.GetInt("platicaConIngeniero");
        int platica = PlayerPrefs.GetInt("platicaConMama2");
        if(platicaIngeniero!=1){
            colliderPlatica.SetActive(false);
        }else if(platica==1){
            barreraSalir.SetActive(false);
            colliderPlatica.SetActive(false);
        }   
    }
}