using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotting : MonoBehaviour
{
    [SerializeField] private float bulletspeed;
    [SerializeField] private float lifetime = 5f;

    private Rigidbody2D bulletrb;

    private void Awake()
    {
        bulletrb = GetComponent<Rigidbody2D>();
    }
    public void shoot(Vector2 direction) 
    {
        bulletrb.velocity = direction * (bulletspeed );
        Destroy(gameObject, lifetime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemyshippart")) 
        {
            Destroy(gameObject);
        }
    }
}
