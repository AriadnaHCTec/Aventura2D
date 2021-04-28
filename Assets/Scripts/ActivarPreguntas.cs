using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 Pone en true el canvas cuando pasa por un collider
Ariadna Huesca Coronado
 */
public class ActivarPreguntas : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CanvasDialogo;    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var currentScene = SceneManager.GetActiveScene();
            var currentSceneName = currentScene.name;
            string pathRelativo = Application.persistentDataPath + "/usuario.txt";
            string texto = System.IO.File.ReadAllText(pathRelativo);

            if(PlayerPrefs.HasKey("preguntas" + texto + currentSceneName)){
                //Destroy(CanvasPregunta);
                //activar canvas dialogo
                CanvasDialogo.SetActive(false);
            }else{
                CanvasDialogo.SetActive(true);
            }


        }
    }
}

