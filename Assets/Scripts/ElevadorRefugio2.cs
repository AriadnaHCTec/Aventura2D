using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElevadorRefugio2 : MonoBehaviour
{
    public bool validar;
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


    void Update() {

        if(validar){
            if(Input.GetKeyDown(KeyCode.E)){
                var currentScene = SceneManager.GetActiveScene();
                var currentSceneName = currentScene.name;
                if(currentSceneName == "Refugio3"){
                    SceneManager.LoadScene("Refugio2");
                }else{
                    SceneManager.LoadScene("Refugio3");
                }
            }  
        }
    }
}
