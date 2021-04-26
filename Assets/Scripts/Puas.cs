using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
    Detecta cuando las puas colisionan con el personaje
    y le resta vida al personaje. Cuando muere el
    personaje, activa la animacion de morir;
    Gurada las monedas y vidas;

    Autor: Miguel Ángel Pérez López
*/

public class Puas : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")){
            
            //Descontar vistas
            SaludPersonaje.instance.RestarVida();
            //SaludPersonaje.instance.vidas--;
            //Actualizar los corazones
            HUD.instance.ActualizarVidas();

            if(SaludPersonaje.instance.vidas<=0){
                SaludPersonaje.instance.PersonajeMuere(NivelActual());
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