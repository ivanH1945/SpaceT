using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Astronaut : MonoBehaviour
{

    
  
    public GameObject pauseui;
    public bool paused;
   

    [SerializeField]
    private Player player;

    public void cargar()
    {

        datosdeljugador playerdata = SistemaDeGuardado.loadPlayerData();
        
       
        Debug.Log("Dataloaded");

    }
    public void guardar()
    {
        SistemaDeGuardado.saveplayerdata( player,this );
        Debug.Log("Datasaved");


    }
    public void pausemenu ()
    {
        if (Input.GetKey(KeyCode.Escape) && paused == false)
        {
            pauseui.SetActive(true);
            Time.timeScale = 0;

        }
    }
    
}
