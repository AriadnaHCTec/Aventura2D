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


    public void GuardarNivelPlayerPrefs(string escena){
        //Obtener nombre de usuario para guardar un playerpref con su nombre
        string pathRelativo = Application.persistentDataPath + "/usuario.txt";
        string texto = System.IO.File.ReadAllText(pathRelativo);
        PlayerPrefs.SetString(texto + "Nivel", escena);
        PlayerPrefs.Save();
    }


    void Update() {

        if(validar){
            if(Input.GetKeyDown(KeyCode.E)){
                GuardarNivelPlayerPrefs("Refugio3");
                SaludPersonaje.instance.SubirInformacionPersonaje();
                SceneManager.LoadScene("Refugio3");
            }  
        }
    }
}
