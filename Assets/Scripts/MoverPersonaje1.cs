/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 *Ariadna Huesca Coronado
 *Código responsable de hacer que el personaje se mueva o salte
*/
/*public class MoverPersonaje : MonoBehaviour
{
    // Máximas velocidades del personaje
    public float maxVelocidadX = 10;
    public float maxVelocidadY = 2;
    private Rigidbody2D rigidbody; //Para física
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>(); //Enlazar RB con el script
    }

    // Update is called once per frame 60 sec
    void Update()
    {
        //Obtenemos respuesta del teclado y se actualiza al rigidbody
        float movHorizontal = Input.GetAxis("Horizontal"); //valor entre -1 y 1//funciona con flecha izq y der o teclas a y d        
        rigidbody.velocity = new Vector2(movHorizontal * maxVelocidadX, rigidbody.velocity.y);//se multiplica el -1 - 1 para que tenga más velocidad
        //el velocity.y hace que se mantenga la velocidad en y sin modificarla porque solo queremos variar la velocidad en x

        //Salto, evitando que se haga 2 veces(en el aire)
        float movVertical = Input.GetAxis("Vertical");
        if (movVertical > 0 && PruebaPiso.estaEnPiso) 
        {               
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, maxVelocidadY);
        }
    }
}
*/