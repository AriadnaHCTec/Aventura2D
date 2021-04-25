using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 Script para leer un JSON con las preguntas
Ariadna Huesca
 */
public class Preguntas : MonoBehaviour
{
    public static Preguntas instance;
    //Para desplegar la información
    public Text pregunta;
    public Text res1;
    public Text res2;
    public Text res3;
    public TextAsset textJson;
    [System.Serializable]

    public class Pregunta
    {
        public string pregunta;
        public string r1;
        public string r2;
        public string r3;
        public int indice;
    }
    [System.Serializable]
    public class Nivel
    {
        public Pregunta[] nivel;
    }

    public Nivel niveles = new Nivel();
    public void Awake()
    {
        instance = this;
    }

    /*void Start()
    {
        niveles = JsonUtility.FromJson<Nivel>(textJson.text);
        pregunta.text = niveles.nivel[0].pregunta.ToString();
        res1.text = niveles.nivel[0].r1.ToString();
        res2.text = niveles.nivel[0].r2.ToString();
        res3.text = niveles.nivel[0].r3.ToString();
    }*/
    
    public void ActualizarCanvas(int indice)
    {
        niveles = JsonUtility.FromJson<Nivel>(textJson.text);
        pregunta.text = niveles.nivel[indice].pregunta.ToString();
        res1.text = niveles.nivel[indice].r1.ToString();
        res2.text = niveles.nivel[indice].r2.ToString();
        res3.text = niveles.nivel[indice].r3.ToString();
    }

    public void Respondio1(int val)
    {
        
        if(niveles.nivel[0].indice == val)
        {
            print("Correctisimo bichota");
        }
        else
        {
            print("nou");
        }        
    }


}
