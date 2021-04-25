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
        public Pregunta[] nivel;
    }

    public Nivel niveles = new Nivel();

    void Start()
    {
        niveles = JsonUtility.FromJson<Nivel>(textJson.text);
        pregunta.text = niveles.nivel[0].pregunta.ToString();
        res1.text = niveles.nivel[0].r1.ToString();
        res2.text = niveles.nivel[0].r2.ToString();
        res3.text = niveles.nivel[0].r3.ToString();
    }

    public void Respondio1(int val)
    {
        
        switch (val)
        {
            case 0:
                if (niveles.nivel[0].indice == 0)
                {
                    print("Correctisimo bichota");
                }
                else
                {
                    print("nou");
                }
                break;
            case 1:
                if (niveles.nivel[0].indice == 1)
                {
                    print("Correctisimo bichota");
                }
                else
                {
                    print("nou");
                }
                break;
            case 2:
                if (niveles.nivel[0].indice == 2)
                {
                    print("Correctisimo bichota");
                }
                else
                {
                    print("nou");
                }
                break;
        }
        
    }


}
