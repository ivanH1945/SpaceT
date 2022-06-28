using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontroller : MonoBehaviour
{
    [SerializeField] private GameObject astronaut;
    [SerializeField] private float speed;
    [SerializeField] private float jumpspeed;
    [SerializeField] private bool grounded;
    


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    private void move() 
    {
        if (Input.GetKey(KeyCode.D)) 
        {
            astronaut.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed * Time.deltaTime, 0));
            astronaut.GetComponent<SpriteRenderer>().flipX = false;
            if (grounded == true) 
            {
                astronaut.GetComponent<Animator>().Play("walk");
            }
            else
            {
                astronaut.GetComponent<Animator>().Play("jetpack");

            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            astronaut.GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed * Time.deltaTime, 0));
            astronaut.GetComponent<SpriteRenderer>().flipX = true;
            if (grounded == true)
            {
                astronaut.GetComponent<Animator>().Play("walk");
            }
            else {
                astronaut.GetComponent<Animator>().Play("jetpack");

            }

        }
        if (grounded == true && Input.GetKeyDown(KeyCode.Space)) 
        {
            astronaut.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0,jumpspeed* Time.deltaTime));

        }
        if (Input.anyKey == false && grounded) 
        {
            astronaut.GetComponent<Animator>().Play("iddle");

        }
        if (Input.anyKey == false && grounded==false)
        {
            astronaut.GetComponent<Animator>().Play("iddle");

        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("ground")) 
        {
            grounded = true;
        }
       
    }
    private void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.collider.CompareTag("ground"))
        {
            grounded = false;
            astronaut.GetComponent<Animator>().Play("jump");




        }
    }

}
