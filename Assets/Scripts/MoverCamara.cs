/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Permite que la cámara siga al personaje.
//Autor:Miguel Ángel Pérez López


public class MoverCamara : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Clamp(personaje.transform.position.x, 0, 17.6f);//largo total-largoResolucion/2=resultado// 27.2-(19.2/2)=17.6
        //float x = personaje.transform.position.x;//la x es del personaje
        float y = Mathf.Clamp(personaje.transform.position.y, 0, 9.4f);//ancho total-anchoResolucion/2=resultado// 14.8-(10.8/2)=9.4
        //float y = transform.position.y;//el y es de la camara
        float z = transform.position.z;//el z es de la camara
        transform.position = new Vector3(x, y, z);
    }
}
*/