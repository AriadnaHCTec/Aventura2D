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
        public Pregunta[] preguntas;
    }

    public Nivel niveles = new Nivel();

    void Start()
    {
        niveles = JsonUtility.FromJson<Nivel>(textJson.text);
        //pregunta.text = niveles.preguntas.ToString();
    }    

    
}
