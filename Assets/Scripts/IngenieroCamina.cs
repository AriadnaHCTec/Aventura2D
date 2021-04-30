using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 Movimiento del ingeniero cuando este interactua con el personaje
Miguel Ángel Pérez López
 */
public class IngenieroCamina : MonoBehaviour
{
    //Variables
    public float maxVelocidadX = 1; //Movimiento horizontal
    private Rigidbody2D rigidbody; //Para la física. Esto es como un apuntador
    public bool parar;
    private Animator anim;//Actualizar el parametro velocidad
    //Sprite Renderer, es para cambiar la orientación, FlipX, FlipY
    private SpriteRenderer sprRenderer;
    

    public void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("SueloIngeniero")){
            parar = true;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        //Inicializar variables
        rigidbody = GetComponent<Rigidbody2D>(); //metodo parametrizado<> //crear la relación entre el rigidbody2d y el script
        anim = GetComponent<Animator>();
        sprRenderer = GetComponent<SpriteRenderer>();
        sprRenderer.flipX = true;
    }


    // Update is called once per frame
    void Update()
    {
        //velocidad
        float velocidad = Mathf.Abs(rigidbody.velocity.x);
        //velocidad es el parametro que declare como condicion en el animator
        anim.SetFloat(name:"velocidad", velocidad);
        if(!parar){
            //Se incrementa la velocidad negativa en x para que avanzar hacia la izquierda 
            rigidbody.velocity = new Vector2(maxVelocidadX, rigidbody.velocity.y);
        }else{
            rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
        }
    }
}
