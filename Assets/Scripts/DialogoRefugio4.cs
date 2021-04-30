using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 Diálogo de Refugio
Miguel Ángel Pérez López
 */
public class DialogoRefugio4 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject panel;//
    public GameObject continueButton;
    public GameObject canvasFinal;//Canvas que cuenta el epilogo
    public GameObject colliderPiso;//borarr el collider que activa la primera platica
    public GameObject HUD;//para desactivarlo
    public GameObject maquina;

    void Start(){
        maquina.SetActive(true);
        PlayerPrefs.DeleteAll();


        //Time.timeScale = 0;
        StartCoroutine(Type());
    }

    void Update() {
        if(textDisplay.text == sentences[index]){
            continueButton.SetActive(true);
        }
    }


    public void GuardarNivelPlayerPrefs(string escena){
        //Obtener nombre de usuario para guardar un playerpref con su nombre
        string pathRelativo = Application.persistentDataPath + "/usuario.txt";
        string texto = System.IO.File.ReadAllText(pathRelativo);
        PlayerPrefs.SetString(texto + "Nivel", escena);
        PlayerPrefs.Save();
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
            SaludPersonaje.instance.SubirPersonajeTerminoJuego();
            HUD.SetActive(false);
            canvasFinal.SetActive(true);
            GuardarNivelPlayerPrefs("Refugio4");
            SaludPersonaje.instance.SubirInformacionPersonaje();
        }
    }

}
