using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")){
            //Descontar vistas
            SaludPersonaje.instance.vidas--;

            //Actualizar los corazones
            HUD.instance.ActualizarVidas();
            if(SaludPersonaje.instance.vidas==0){
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
