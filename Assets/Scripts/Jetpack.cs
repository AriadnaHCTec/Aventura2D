using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jetpack : MonoBehaviour
{
    public bool validar;
    public GameObject panelInformativo;//panel que le dice que apriete una tecla para usar el helicoptero
    // Start is called before the first frame update
    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")){
            validar=true;
            panelInformativo.SetActive(validar);

        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        validar = false;     
        //activar canvas texto
        panelInformativo.SetActive(validar);
    }

    void Update(){
        if(validar){
            if(Input.GetKeyDown(KeyCode.E)){
                var currentScene = SceneManager.GetActiveScene();
                var currentSceneName = currentScene.name;
                SceneManager.LoadScene("Edificio2");
            }
        }
    }
}
