using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_DE_La_Nave_Enemiga : MonoBehaviour
{


    private GameObject movementShip;
    [SerializeField]
    private float rangoAgro; //rango de vista del enemigo 
    [SerializeField]
    private float VelocidadDeMovimineto;
    [SerializeField]
    Rigidbody2D RB2D;
    [SerializeField]
    private bool onrange;

    void Start()
    {
        RB2D = GetComponent<Rigidbody2D>();
        movementShip = GameObject.FindGameObjectWithTag("ship");
        onrange = false;
    }

    // Update is called once per frame
    void Update()
    {
        CorretearJugador();
    }

    

    private void CorretearJugador()
    {
        if (onrange == true)
        {
            transform.position = new Vector3(movementShip.transform.position.x + VelocidadDeMovimineto, movementShip.transform.position.y + VelocidadDeMovimineto, -394);
            VelocidadDeMovimineto = -Time.deltaTime;
        }
        else {

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("ship"))
        {
            onrange = true;
        }
    }
    private void OnTriggereExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ship"))
        {
            onrange = false;
        }
    }
}
