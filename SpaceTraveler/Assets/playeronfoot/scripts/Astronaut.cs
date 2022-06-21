using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Astronaut : MonoBehaviour
{
    [SerializeField] private GameObject tabletobj;
    bool on = false;



    private void Start()
    {

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T)) 
        {
            if (on == false)
            {
                getTablet();

            }
            else {
                hidetablet();
            }

        }
    }

    public void getTablet() 
    {
  
            tabletobj.SetActive(true);
        on = true;
       
    }
    public void hidetablet()
    {

        tabletobj.SetActive(false);
        on = false;
        
      

    }



}
