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
    public float limiteIX;
    public float limiteIY;
    public float limiteX;
    public float limiteY;
    
    
    // Start is called before the first frame update
    void Start()
    {
     
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Clamp( personaje.transform.position.x, limiteIX, limiteX);
        float y = Mathf.Clamp(personaje.transform.position.y, limiteIY, limiteY);
        float z = transform.position.z;
        transform.position = new Vector3(x, y, z);
    }
}
