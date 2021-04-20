using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlaticasRefugio : MonoBehaviour
{
    public GameObject CanvasDialogoMama1;
    public GameObject DialogoManagerMama1;
    public GameObject CanvasDialogoMama2;
    public GameObject DialogoManagerMama2;
    public GameObject BarreraControlPlatica1;
    public GameObject BarreraControlPlatica2;
    public GameObject ColliderPlatica2;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        int platicaIngeniero1 = PlayerPrefs.GetInt("platicaConIngeniero");
        if (platicaIngeniero1 == 1){
            CanvasDialogoMama1.SetActive(false);
            DialogoManagerMama1.SetActive(false);
            ColliderPlatica2.SetActive(true);///collidr que activa la platica con mama2
            Destroy(BarreraControlPlatica1, 0.5f);
        }
        int platicaMama2 = PlayerPrefs.GetInt("platicaConMama2");
        if(platicaMama2==1){
            CanvasDialogoMama2.SetActive(false);
            DialogoManagerMama2.SetActive(false);
            BarreraControlPlatica2.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
