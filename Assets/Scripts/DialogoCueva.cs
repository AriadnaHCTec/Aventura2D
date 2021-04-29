using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

/*
Codigo para hacer platica con Kathlenn

Autor: Miguel Ángel Pérez López
*/

public class DialogoCueva : MonoBehaviour
{
public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject panel;//
    public GameObject continueButton;
    public GameObject colliderPlatica;//Collider que activa la platica con Kathleen//se declara para destruirlo
    public GameObject panelPreguntas;//panel donde el jugador debe responder varias preguntas

    void Start() {
        //Time.timeScale = 0;
        StartCoroutine(Type());
    }

    void Update() {
        if(textDisplay.text == sentences[index]){
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type(){
        foreach(char letter in sentences[index].ToCharArray()){
            textDisplay.text += letter; 
            yield return new WaitForSeconds(typingSpeed);
        }
    }


    public void NextSentence(){
        continueButton.SetActive(false);

        if(index < sentences.Length - 1){
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }else{
            textDisplay.text = "";
            //Destroy(boton,0.5f);
            continueButton.SetActive(false);
            panel.SetActive(false);

            //verificar si el jugador ya respondio las preguntas antes
            var currentScene = SceneManager.GetActiveScene();
            var currentSceneName = currentScene.name;
            string pathRelativo = Application.persistentDataPath + "/usuario.txt";
            string texto = System.IO.File.ReadAllText(pathRelativo);
            if(PlayerPrefs.HasKey("preguntas" + texto + currentSceneName)){
                //activar canvas dialogo
                panelPreguntas.SetActive(false);
            }else{
                panelPreguntas.SetActive(true);//activar panel para hacer preguntas
            }
            Destroy(colliderPlatica, 0.5f);
        }
    }
}
