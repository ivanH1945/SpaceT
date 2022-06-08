using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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






    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    private void move()
    {
        bool engineon = false;

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * speedforce * Time.deltaTime, ForceMode2D.Impulse);
            gameObject.GetComponent<Animator>().Play("avancegameplay");
            engineon = true;

        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, rotationforce * Time.deltaTime * direction);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -rotationforce * Time.deltaTime * direction);

        }
        while (engineon == true)
        {
            if (engine.isPlaying == true)
            {
                Debug.Log("se esta reproduciendo");
            }
            else {
                engine.Play();
            } 
        }

    }
}
