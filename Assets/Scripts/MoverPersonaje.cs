/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Permite al personaje moverse hacia la izquierda, derecha
//y hacia arriba con el teclado.
//Autor: Miguel Ángel Pérez López


public class MoverPersonaje : MonoBehaviour
{

    //Variables
    public float maxVelocidadX = 10; //Movimiento horizontal
    public float maxVelocidadY = 10; //Movimiento vertical

    private Rigidbody2D rigidbody; //Para la física. Esto es como un apuntador

    // Start is called before the first frame update
    void Start()
    {
        //Inicializar variables
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //mover de izq a der
        float movHorizontal = Input.GetAxis("Horizontal");
        rigidbody.velocity = new Vector2(movHorizontal * maxVelocidadX, rigidbody.velocity.y);
       

        //Salto
        float movVertical = Input.GetAxis("Vertical");
        if(movVertical > 0 && PruebaPiso.estaEnPiso){
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, maxVelocidadY);
        }
    }
}
*/