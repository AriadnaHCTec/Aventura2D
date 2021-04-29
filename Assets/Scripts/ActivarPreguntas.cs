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
    public GameObject canvasExplicacion;    
    public GameObject libro;//para aparecerlo hasta que acabe las preguntas
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var currentScene = SceneManager.GetActiveScene();
            var currentSceneName = currentScene.name;
            string pathRelativo = Application.persistentDataPath + "/usuario.txt";
            string texto = System.IO.File.ReadAllText(pathRelativo);

            if(PlayerPrefs.HasKey("preguntas" + texto + currentSceneName)){
                //activar canvas dialogo
                canvasExplicacion.SetActive(false);
                libro.SetActive(true);
            }else{
                canvasExplicacion.SetActive(true);
                libro.SetActive(true);
            }
        }
    }
}

