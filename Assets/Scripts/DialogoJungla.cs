using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

/*
 Diálogo del nivel Jungla
Miguel Ángel Pérez López
 */
public class DialogoJungla : MonoBehaviour
{
public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject panel;//
    public GameObject continueButton;
    public GameObject colliderPlatica;//Collider que activa la platica con Kathleen//se declara para destruirlo
    public GameObject panelPreguntas;
    public GameObject helicoptero;
    public GameObject canvasExplicacion;
    

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
            Destroy(colliderPlatica, 0.5f);

            //verificar si el jugador ya respondio las preguntas antes
            var currentScene = SceneManager.GetActiveScene();
            var currentSceneName = currentScene.name;
            string pathRelativo = Application.persistentDataPath + "/usuario.txt";
            string texto = System.IO.File.ReadAllText(pathRelativo);
            if(PlayerPrefs.HasKey("preguntas" + texto + currentSceneName)){
                canvasExplicacion.SetActive(false);
                panelPreguntas.SetActive(false);
            }else{
                canvasExplicacion.SetActive(true);//activar panel de explicacion
            }
            helicoptero.SetActive(true);
        }
    }
}
