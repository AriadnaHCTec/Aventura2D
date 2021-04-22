using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificarPlaticaIngeniero : MonoBehaviour
{
    public GameObject IngenieroAnimacion;
    public GameObject IngenieroImagen;
    public GameObject colliderPlatica;
    public GameObject elevador;

    void Start(){
        elevador.SetActive(true);
        elevador.SetActive(false);        
        /*
        int platica = PlayerPrefs.GetInt("platicaConIngeniero");
        if(platica==1){
            IngenieroAnimacion.SetActive(false);
            IngenieroImagen.SetActive(false);
            colliderPlatica.SetActive(false);
        } 
        */  
    }
}
