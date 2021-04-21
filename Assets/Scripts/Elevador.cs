using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Elevador : MonoBehaviour
{
    public bool validar;
    public GameObject jugador;
    public GameObject pantallaInformativa;
    public bool yaUsoElevador = false;

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


    void Start(){
        if(yaUsoElevador)
        jugador.transform.position = new Vector3(-35, -7, -5);
    }


    void Update() {

        if(validar){
            if(Input.GetKeyDown(KeyCode.E)){
                yaUsoElevador = true;
                //Scene currentScene = SceneManager.GetActiveScene();
                //string sceneName = currentScene.name;
                var currentScene = SceneManager.GetActiveScene();
                var currentSceneName = currentScene.name;
                if(currentSceneName == "Refugio"){
                    //Destroy(jugador, 0.5f);
                    
                    SceneManager.LoadScene("Refugio2");
                }else{
                    SceneManager.LoadScene("Refugio");
                    
                }
                
            }  
        }
    }

}
