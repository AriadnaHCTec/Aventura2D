using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SaludPersonaje : MonoBehaviour
{
    //public string nombreUsuario = "";
    public int vidas = 4;
    public int monedas = 0;
    public int monedasPorNivel = 0;//estas monedas se guardan pero si el jugador muere en el nivel se borran
    public int nivel=1;
    public int preguntasCorrectasTotal=0;
    public int preguntasCorrectasEdif1=0;
    public int preguntasCorrectasJungla=0;
    public int preguntasCorrectasCueva=0;
    public int preguntasCorrectasEdif2=0;
    public int intentoPreguntas = 0;
    public static SaludPersonaje instance;
    private Rigidbody2D rigidbody;//animacion muerto
    public BoxCollider2D collider2D;//desactivar para que no le bajen más vidas al jugador cuando muere
    public DateTime tiempoInicio;
    public DateTime tiempoFinal;
    public float tiempoTotal;
    public AudioSource sonidoHerido;
    public AudioSource sonidoMuere;
    public int acaboNivel = 0;//valor que se guardara en base de datos para confirmar que el jugador acabo el juego


    private void Awake(){
        instance = this; //this es un apuntador al objeto que esta ejecutando el código
    }


    public void Start(){
        try{
            CargarInfo();
        }
        catch{
            GuardarInfo();
        }

    }


    public void GuardarInfo(){
        GuardarDatos.GuardarInfo(this);
    }

    public void CargarInfo(){
        Personaje data = GuardarDatos.CargarInfo();
        //nombreUsuario = data.nombreUsuario;
        vidas = data.vidas;
        monedas = data.monedas;
        monedasPorNivel = data.monedasPorNivel;
        nivel = data.nivel;
        preguntasCorrectasTotal = data.preguntasCorrectasTotal;
        preguntasCorrectasEdif1 = data.preguntasCorrectasEdif1;
        preguntasCorrectasJungla = data.preguntasCorrectasJungla;
        preguntasCorrectasCueva = data.preguntasCorrectasCueva;
        preguntasCorrectasEdif2 = data.preguntasCorrectasEdif1;
        intentoPreguntas = data.intentoPreguntas;
        tiempoInicio = data.tiempoInicio;
        tiempoFinal = data.tiempoFinal;
        tiempoTotal = data.tiempoTotal;
    }    


    public void AumentarMonedas(){
        CargarInfo();
        monedas += 25;
        GuardarInfo();
    }


    public void AumentarMonedasTemporales(){
        CargarInfo();
        monedasPorNivel += 25;
        GuardarInfo();
    }


    public void ConservarMonedasTemporales(){
        //Se corre este metodo cuando el jugador usa el helicoptero o jetpack
        //Se hace 0 para que en el siguiente nivel si muere, no se le resten
        //las monedas que habia conseguido en el pasado nivel
        CargarInfo();
        monedasPorNivel = 0;
        GuardarInfo();
    }


    public void RestarVida(){
        CargarInfo();
        sonidoHerido.Play();
        vidas = RegresarVidas();
        vidas -= 1;
        GuardarInfo();
    }

    /*
    public void MatarUnEnemigo(){
        //Metodo que le regresa una vida al jugador porque es imposible
        // matar a un enemigo sin perder una vida por acerarse
        CargarInfo();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
        vidas += 1;
        GuardarInfo();
    }*/


    public int SumarPreguntasTotales(){
        CargarInfo();
        return (preguntasCorrectasEdif1 + preguntasCorrectasJungla + preguntasCorrectasCueva + preguntasCorrectasEdif2);
    }


    public void SumarIntentos(){
        CargarInfo();
        intentoPreguntas += 1;
        GuardarInfo();
    }


    public void SumarPuntosDeNivel(){
        var currentScene = SceneManager.GetActiveScene();
        var currentSceneName = currentScene.name;
        CargarInfo();
        if(currentSceneName == "Edificio1"){
            preguntasCorrectasEdif1 += 1;
        }else if(currentSceneName == "Jungla"){
            preguntasCorrectasJungla += 1;
        }else if(currentSceneName == "Cueva 1"){
            preguntasCorrectasCueva += 1;
        }else if(currentSceneName == "Edificio2"){
            preguntasCorrectasEdif2 +=1;
        }else{
            preguntasCorrectasTotal += 0;
        }
        GuardarInfo();
    }


    public void PersonajeMuere(int nivell){
        CargarInfo();
        monedas -= monedasPorNivel;
        monedasPorNivel = 0;
        nivel = nivell;
        //GuardarNivelPlayerPrefs();

        tiempoFinal = DateTime.Now;
        TimeSpan span = tiempoFinal.Subtract ( tiempoInicio );
        tiempoTotal = span.Minutes;

        sonidoMuere.Play();

        rigidbody = GetComponent<Rigidbody2D>();
        collider2D.enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
        rigidbody.constraints = RigidbodyConstraints2D.FreezePosition;
        gameObject.transform.GetChild(2).gameObject.SetActive(true);          
        vidas = 4;
        GuardarInfo();

        //Destroy(gameObject, 0.5f);
        Invoke("CargarNivelActual", 1.5f);
    }


    public void SalirDelJuego(){
        //Al salir del juego, elimina las monedas temporales
        CargarInfo();
        //GuardarNivelPlayerPrefs();
        monedas -= monedasPorNivel;
        monedasPorNivel = 0;
        GuardarInfo();
    }


    public int RegresarVidas(){
        CargarInfo();
        if(vidas >= 5){
            vidas = 4;
            return 4;
        }else if(vidas < 0){
            vidas = 0;
            return 0;
        }else{
            return vidas;
        }
        
    }


    public int RegresarNivel(){
        //GuardarNivelPlayerPrefs();
        CargarInfo();
        return nivel;
    }

    /*
    public void EscribirTxtNivel(){
        CargarInfo();
        string path = Application.persistentDataPath + "/nivel.txt";
        System.IO.File.WriteAllText(path, CargarNivelActualString());
        GuardarInfo();
    }*/

    public void SubirPersonajeTerminoJuego(){
        CambiarEstadoFinal.instance.EscribirJson2();
    }


    public void SubirInformacionPersonaje(){
        //Restar monedas temporales del nivel
        CargarInfo();
        SalirDelJuego();
        EnviarDatos.instance.EscribirJson();
    }


    public void CargarNivelActual(){
        tiempoInicio = DateTime.Now;
        int nivell = SaludPersonaje.instance.RegresarNivel();
        if(nivell == 1){
            SceneManager.LoadScene("Refugio");
        }else if(nivell == 2){
            SceneManager.LoadScene("Refugio2");
        }else if(nivell==3){
            SceneManager.LoadScene("Refugio3");
        }else if(nivell == 4){
            SceneManager.LoadScene("Edificio1");
        }else if(nivell == 5){
            SceneManager.LoadScene("Jungla");
        }else if(nivell == 6){
            SceneManager.LoadScene("Cueva 1");
        }else if(nivell == 7){
            SceneManager.LoadScene("Edificio2");
        }else if(nivell == 8){
            SceneManager.LoadScene("Refugio4");
        }else{
            SceneManager.LoadScene("Refugio");//checar este caso
        }
    }


    public string CargarNivelActualString(){
        int nivell = SaludPersonaje.instance.RegresarNivel();
        if(nivell == 1){
            return "Refugio";
        }else if(nivell == 2){
            return "Refugio2";
        }else if(nivell==3){
            return "Refugio3";
        }else if(nivell == 4){
            return "Edificio1";
        }else if(nivell == 5){
            return "Jungla";
        }else if(nivell == 6){
            return "Cueva 1";
        }else if(nivell == 7){
            return "Edificio2";
        }else if(nivell == 8){
            return "Refugio4";
        }else{
            return "Refugio";
        }
    }

    /*
    public void GuardarNivelPlayerPrefs(){
        var currentScene = SceneManager.GetActiveScene();
        var currentSceneName = currentScene.name;
        //Obtener nombre de usuario para guardar un playerpref con su nombre
        string pathRelativo = Application.persistentDataPath + "/usuario.txt";
        string texto = System.IO.File.ReadAllText(pathRelativo);
        PlayerPrefs.SetString(texto + "Nivel",currentSceneName);
        PlayerPrefs.Save();
    }*/
}
