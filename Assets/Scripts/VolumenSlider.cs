using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;//librería para acceder a objetos AudioMixer

/*
Hace una conexion con AudioMixer para que se modifique
el volumen con un slider en el menu de configuracion

Autor: Miguel Ángel Pérez López
*/

public class VolumenSlider : MonoBehaviour
{
    public AudioMixer mixer;


    public void SetLevel(float sliderValue){
        mixer.SetFloat("MusicVol",Mathf.Log10(sliderValue) * 20);
    }
}
