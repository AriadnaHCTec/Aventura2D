using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialogo2Refugio2 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject panel;//
    public GameObject continueButton;
    public GameObject barreraControl; //barrera que prohibe que salga del cuarto hasta que acabe la platica


    void Start(){
        PlayerPrefs.DeleteAll();


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
            continueButton.SetActive(false);
            panel.SetActive(false);
            Destroy(barreraControl,0.5f);//BarreraCuartoDeIngeniero
            PlayerPrefs.SetInt("platicaConIngeniero",1);
            PlayerPrefs.Save();
        }
    }
}