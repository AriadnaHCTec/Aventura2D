using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 Hace transición de escena al interactuar con el helicóptero
Miguel Ángel Pérez López
 */
public class Helicoptero : MonoBehaviour
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


    public void GuardarNivelPlayerPrefs(string escena){
        //Obtener nombre de usuario para guardar un playerpref con su nombre
        string pathRelativo = Application.persistentDataPath + "/usuario.txt";
        string texto = System.IO.File.ReadAllText(pathRelativo);
        PlayerPrefs.SetString(texto + "Nivel", escena);
        PlayerPrefs.Save();
    }


    void Update(){
        if(validar){
            if(Input.GetKeyDown(KeyCode.E)){
                //Mantener las monedas temporales del nivel porque el jugador 
                //paso de nivel y tiene derecho a conservar las monedas temporales
                SaludPersonaje.instance.ConservarMonedasTemporales();

                var currentScene = SceneManager.GetActiveScene();
                var currentSceneName = currentScene.name;
                if(currentSceneName == "Edificio1"){
                    GuardarNivelPlayerPrefs("Jungla");
                    SaludPersonaje.instance.SubirInformacionPersonaje();
                    SceneManager.LoadScene("Jungla");
                }else if(currentSceneName == "Jungla"){
                    GuardarNivelPlayerPrefs("Cueva 1");
                    SaludPersonaje.instance.SubirInformacionPersonaje();
                    SceneManager.LoadScene("Cueva 1");
                }
            } 
        } 
    }
}
