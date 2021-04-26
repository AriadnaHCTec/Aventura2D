using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirDeEdificio : MonoBehaviour
{
    public bool validar;
    public GameObject pantallaInformativa;


    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Player")){
            //Mostrar texto para usar el elevador
            validar=true;
            //activar canvas texto
            pantallaInformativa.SetActive(validar);
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        validar = false;     
        //activar canvas texto
        pantallaInformativa.SetActive(validar);
    }


    void Update() {

        if(validar){
            if(Input.GetKeyDown(KeyCode.E)){
                SceneManager.LoadScene("Refugio4");
            }  
        }
    }
}
