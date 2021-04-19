using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Mover al personaje 
Ariadna Huesca Coronado
 */
public class MoverPersonaje : MonoBehaviour
{
    // VARIABLES
    public float maxVelocidadX = 10;    // Mov. horizontal  <-    ->
    public float maxVelocidadY = 7;    // Mov. Vertical ^

    private Rigidbody2D rigidbody;      // Para física


    // METODOS

    // Start is called before the first frame update
    void Start()
    {
        // Inicializar variables
        rigidbody = GetComponent<Rigidbody2D>();    // Enlazar RB -> script
        //float x = PlayerPrefs.GetFloat("posicionX", -3.4f);
        //float y = PlayerPrefs.GetFloat("posicionY", -1.8f);
        //SaludPersonaje.instance.posicionX = x;
        //SaludPersonaje.instance.posicionY = y;
        //gameObject.transform.position = new Vector3(x, y, -5);        
    }

    // Update is called once per frame (FRECUENTEMENTE, 60 veces/seg)
    void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");   // [-1, 1]

        rigidbody.velocity = new Vector2(movHorizontal * maxVelocidadX, rigidbody.velocity.y);

        // Salto (Después lo vamos a resolver con JUMP)
        float movVertical = Input.GetAxis("Vertical");
        if (movVertical > 0 && PruebaPiso.estaEnPiso)
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, maxVelocidadY);
        }
    }
}
