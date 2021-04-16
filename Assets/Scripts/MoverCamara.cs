using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Permite que la cámara siga al personaje
 * Autor: Roberto Mtz. Román
 */
public class MoverCamara : MonoBehaviour
{
    public GameObject personaje;
    public float limiteY;
    public float limiteX;
    
    // Start is called before the first frame update
    void Start()
    {
     
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Clamp( personaje.transform.position.x, 0, limiteX);
        float y = Mathf.Clamp(personaje.transform.position.y, 0, limiteY);
        float z = transform.position.z;
        transform.position = new Vector3(x, y, z);
    }
}
