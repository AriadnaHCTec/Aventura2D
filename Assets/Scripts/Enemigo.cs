using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
    Detecta cuando los enemigos colisionan con el personaje
    y le resta vida al personaje. Cuando muere el
    personaje, activa la animacion de morir;
    Gurada las monedas y vidas;

    Autor: Miguel Ángel Pérez López
*/

public class Enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("martillo")){
            if(SaludPersonaje.instance.vidas<=0){
                //sonidoMuere.Play();
                SaludPersonaje.instance.PersonajeMuere(NivelActual());
            }
            Destroy(gameObject, 0.5f);
        }else if (other.gameObject.CompareTag("Player")){
            //Sonido daño
            //sonidoHerido.Play();
            
            //Descontar vistas
            SaludPersonaje.instance.RestarVida();
            
            //Actualizar los corazones
            HUD.instance.ActualizarVidas();

            if(SaludPersonaje.instance.vidas<=0){
                //sonidoMuere.Play();
                SaludPersonaje.instance.PersonajeMuere(NivelActual());
                //HUD.instance.ActualizarVidas();
                
                //PlayerPrefs.SetInt("nivel",nivel);
                //Almacenar en preferencias las monedas recolectadas hasta el momento
                //PlayerPrefs.SetInt("numeroMonedas",SaludPersonaje.instance.monedas);
                //hasta que termine la aplicacion se guardan los valores
                //PlayerPrefs.Save();//Guardar preferencias

                //efectoMuere.Play();
                //Destroy(other.gameObject, 1.0f);
                //SceneManager.LoadScene("EscenaMenu");//Pierde regresa al menu
            }     
        }
    }


    public int NivelActual(){
        var currentScene = SceneManager.GetActiveScene();
        var currentSceneName = currentScene.name;
        if(currentSceneName=="Refugio3"){
            return 1;
        }else if(currentSceneName=="Edificio1"){
            return 2;
        }else if(currentSceneName=="Jungla"){
            return 3;
        }else if(currentSceneName=="Cueva 1"){
            return 4;
        }else if(currentSceneName=="Edificio2"){
            return 5;
        }else{
            return 0;
        }
    }
}