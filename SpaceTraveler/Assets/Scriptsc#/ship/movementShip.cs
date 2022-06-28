using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class movementShip : MonoBehaviour
{
    [SerializeField]
    private float speedforce;
    [SerializeField]
    private float rotationforce;
    [SerializeField]
    private float direction;
    [SerializeField]
    AudioSource engine;
    [SerializeField]
    Text cords;
   
   
  



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        move();
        Cords();
    }

    private void move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * speedforce * Time.deltaTime, ForceMode2D.Impulse);
            gameObject.GetComponent<Animator>().Play("avancegameplay");



        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * (5 * speedforce) * Time.deltaTime, ForceMode2D.Impulse);
            gameObject.GetComponent<Animator>().Play("avancegameplay");

        }




        if (Input.GetKeyDown(KeyCode.W))
        {

            engine.Play();

        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {

            engine.Play();
            engine.pitch = 1.5f;

        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {


            engine.pitch = 1f;

        }
        if (Input.GetKeyUp(KeyCode.W))
        {

            engine.Stop();

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, rotationforce * Time.deltaTime * direction);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -rotationforce * Time.deltaTime * direction);

        }

    }

    private void Cords()
    {
        cords.text = "X= " + this.gameObject.transform.position.x + "Y= " + this.transform.position.y; 
    }
}
