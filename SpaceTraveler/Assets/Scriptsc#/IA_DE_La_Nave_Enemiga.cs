using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_DE_La_Nave_Enemiga : MonoBehaviour
{

    [SerializeField]
    Transform movementShip;
    [SerializeField]
    Transform rangoAgro; //rango de vista del enemigo 

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
    }
}
