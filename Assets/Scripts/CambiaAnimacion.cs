/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Permite modificar el parametro velocidad del Animator
//para hacer las transiciones
//Autor: Miguel Ángel Pérez López


public class CambiaAnimacion : MonoBehaviour
{

    private Rigidbody2D rb2D;
    private Animator anim;
    private SpriteRenderer sprRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //Inicializar las varibales
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //velocidad
        float velocidad = Mathf.Abs(rb2D.velocity.x);

        anim.SetFloat(name:"velocidad", velocidad);


        if(rb2D.velocity.x > 0){
            sprRenderer.flipX = false;
        }else if(rb2D.velocity.x < 0){
            sprRenderer.flipX = true;
        }

        //Verificar si el personaje esta saltando
        //anim.SetBool("saltando", !PruebaPiso.estaEnPiso);
    }
    }
}
*/