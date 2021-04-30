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
    private bool estaAnimacion = false;
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
        if (!estaAnimacion)
        {
            float movHorizontal = Input.GetAxis("Horizontal");   // [-1, 1]

            rigidbody.velocity = new Vector2(movHorizontal * maxVelocidadX, rigidbody.velocity.y);

            // Salto (Después lo vamos a resolver con JUMP)
            float movVertical = Input.GetAxis("Vertical");
            if (movVertical > 0 && PruebaPiso.estaEnPiso)
            {
                rigidbody.velocity = new Vector2(rigidbody.velocity.x, maxVelocidadY);
            }

            if (Input.GetKeyDown(KeyCode.H))//tecla h
            {
                //GameObject nuevo = Instantiate(proyectil);
                rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
                estaAnimacion = true;
                //GetComponent<SpriteRenderer>().enabled = false;
                //rigidbody.constraints = RigidbodyConstraints2D.FreezePosition;
                // Prender la explosión
                // moneda.transform.hijo del transform(transform de la explosion).explosion.Se hace activa
                gameObject.transform.GetChild(3).gameObject.SetActive(true);
                StartCoroutine(GenerarDisparo());
            }
        }
        
        
    }

    private IEnumerator GenerarDisparo()
    {
        yield return new WaitForSeconds(.8f);//se va a dormir 1.35 segundos

        //Despues va a cotninuar y va a disparar
        gameObject.transform.GetChild(3).gameObject.SetActive(false);
        GetComponent<SpriteRenderer>().enabled = true;
        estaAnimacion = false;
        
    }
}
