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
    [SerializeField]
    AudioSource music;
    [SerializeField]
    GameObject menu;
    bool paused;
  



    // Start is called before the first frame update
    void Start()
    {
        paused = false;
        unpause();
       
    }

    // Update is called once per frame
    void Update()
    {
        move();
     
    }

    private void move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * speedforce * Time.deltaTime, ForceMode2D.Impulse);
            gameObject.GetComponent<Animator>().Play("avancegameplay");
            


        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift) )
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * (10 * speedforce) * Time.deltaTime, ForceMode2D.Impulse);
            gameObject.GetComponent<Animator>().Play("avancegameplay");
        
        }
       
       


        if (Input.GetKeyDown(KeyCode.W))
        {

            engine.Play();

        }
        if (Input.GetKeyDown(KeyCode.LeftShift) )
        {

            engine.Play();
            engine.pitch=1;

        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {

          
            engine.pitch = 0.42f;

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


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused == false) 
            {
                pause();
            }
            else
            {
                unpause();
            }
            
                
        }

       
    }
    public void pause()
    {
        menu.SetActive(true);
        engine.Pause();
        music.Pause();
        Time.timeScale = 0;
        paused = true;
    }
    public void unpause()
    {
        menu.SetActive(false);
        engine.UnPause();
        music.UnPause();
        Time.timeScale = 1;
        paused = false;
    }

}
