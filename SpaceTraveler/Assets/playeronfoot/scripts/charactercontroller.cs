using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontroller : MonoBehaviour
{
    public float velocidad;
    private Rigidbody2D rigidbody;
    private bool mirandoDerecha = true;
    // Start is called before the first frame update
    void Start()
    {

        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcesarMovimiento();
    }

    void ProcesarMovimiento()
    {
        //logica de movimiento 
        float inputMovimiento = Input.GetAxis("Horizontal");
        
        rigidbody.velocity = new Vector2(inputMovimiento * velocidad, rigidbody.velocity.y);

        GestionarOrientacion(inputMovimiento);
    }
    void GestionarOrientacion(float inputMovimiento)
    {
        // si cumple la condicion 
        if ((mirandoDerecha == true && inputMovimiento < 0) || (mirandoDerecha == false && inputMovimiento > 0)) 
        {
            //Ejecutar codigo de volteado
            mirandoDerecha = !mirandoDerecha;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }

    }
}
