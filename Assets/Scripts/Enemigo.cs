using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{
    public int nivel;
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")){
            //Descontar vistas
            SaludPersonaje.instance.vidas--;

            //Actualizar los corazones
            HUD.instance.ActualizarVidas();
            if(SaludPersonaje.instance.vidas==0){
                var currentScene = SceneManager.GetActiveScene();
                var currentSceneName = currentScene.name;
                if(currentSceneName=="Refugio3"){
                    nivel = 1;
                }else if(currentSceneName=="Edificio1"){
                    nivel = 2;
                }else if(currentSceneName=="Jungla"){
                    nivel = 3;
                }else if(currentSceneName=="Cueva 1"){
                    nivel = 4;
                }
                PlayerPrefs.SetInt("nivel",nivel);

                //Almacenar en preferencias las monedas recolectadas hasta el momento
                PlayerPrefs.SetInt("numeroMonedas",SaludPersonaje.instance.monedas);
                //hasta que termine la aplicacion se guardan los valores
                PlayerPrefs.Save();//Guardar preferencias

                //efectoMuere.Play();
                Destroy(other.gameObject, 1.0f);
                //SceneManager.LoadScene("EscenaMenu");//Pierde regresa al menu
            }        
        }
    }
}
