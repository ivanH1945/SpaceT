using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_DE_La_Nave_Enemiga : MonoBehaviour
{

    [SerializeField]
    Transform movementShip;
    [SerializeField]
   float rangoAgro; //rango de vista del enemigo 
    public float VelocidadDeMovimineto;
    Rigidbody2D RB2D;

    void Start()
    {
        RB2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float Distancia_Del_Jugador = Vector2.Distance(transform.position, movementShip.position);
        Debug.Log("Distancia del Jugador :" + Distancia_Del_Jugador);
        if(Distancia_Del_Jugador < rangoAgro)
        {
            CorretearJugador();

        }
        else
        {
            NoCorretear();
        }
    }

    private void NoCorretear()
    {
        
    }

    private void CorretearJugador()
    {
      if(transform.position.x < movementShip.position.x)
        {
            RB2D.velocity = new Vector2(VelocidadDeMovimineto,0f);
        }
      else if(transform.position.x> movementShip.position.x)
        {
            RB2D.velocity = new Vector2(-VelocidadDeMovimineto, 0f);
        }
      if(transform.position.y < movementShip.position.y) { 
            RB2D.velocity = new Vector2(0f, VelocidadDeMovimineto);
    }else if(transform.position.y > movementShip.position.y)
        {
            RB2D.velocity = new Vector2(0f, -VelocidadDeMovimineto);
        }
    }
   
}
