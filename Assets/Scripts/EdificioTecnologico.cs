using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EdificioTecnologico : MonoBehaviour
{
    public static bool validar;
    public GameObject jugador;
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

    // Update is called once per frame
    void Update(){
        if(validar){
            //activar canvas texto
            pantallaInformativa.SetActive(validar);

            if(Input.GetKeyDown(KeyCode.E)){
                SceneManager.LoadScene("Edificio1");
            }  
        } 
    }
}
