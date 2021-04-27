using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EdificioTecnologico : MonoBehaviour
{
    public static bool validar;
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


    public void GuardarNivelPlayerPrefs(string escena){
        //Obtener nombre de usuario para guardar un playerpref con su nombre
        string pathRelativo = Application.persistentDataPath + "/usuario.txt";
        string texto = System.IO.File.ReadAllText(pathRelativo);
        PlayerPrefs.SetString(texto + "Nivel", escena);
        PlayerPrefs.Save();
    }


    // Update is called once per frame
    void Update(){
        if(validar){
            //activar canvas texto
            pantallaInformativa.SetActive(validar);

            if(Input.GetKeyDown(KeyCode.E)){
                //Mantener las monedas temporales del nivel porque el jugador 
                //paso de nivel y tiene derecho a conservar las monedas temporales
                SaludPersonaje.instance.ConservarMonedasTemporales();
                GuardarNivelPlayerPrefs("Edificio1");
                SaludPersonaje.instance.SubirInformacionPersonaje();
                SceneManager.LoadScene("Edificio1");
            }  
        } 
    }
}
