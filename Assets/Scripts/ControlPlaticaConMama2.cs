using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlaticaConMama2 : MonoBehaviour
{
    public GameObject CanvasDialogo;
    public GameObject DialogManager;
    public GameObject barreraSalir;//Barrera para salir del refugio

    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Player")){
            //activar canvas dialogo
            CanvasDialogo.SetActive(true);
            DialogManager.SetActive(true);
            Destroy(barreraSalir,0.1f);
            //barreraSalir.SetActive(false);
            /*PlayerPrefs.SetInt("platicaConMama2",1);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("platicaConIngeniero",1);
            PlayerPrefs.Save();
            */
        }
    }
}
