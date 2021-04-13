using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Elevador : MonoBehaviour
{
    public bool validar;
    public GameObject jugador;
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Player")){
            //Mostrar texto para usar el elevador


            validar=true;
  
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        validar = false;        
    }


    void Update() {
        if(validar){
            if(Input.GetKeyDown(KeyCode.E)){
                //Scene currentScene = SceneManager.GetActiveScene();
                //string sceneName = currentScene.name;
                var currentScene = SceneManager.GetActiveScene();
                var currentSceneName = currentScene.name;
                if(currentSceneName == "Refugio"){
                    //Destroy(jugador, 0.5f);
                    SceneManager.LoadScene("Refugio2");
                }else{
                    SceneManager.LoadScene("Refugio");
                    jugador.transform.position = new Vector3(-35, -7, -4);
                    
                }
                
            }  
        }
    }

}
