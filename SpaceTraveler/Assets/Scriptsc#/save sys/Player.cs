using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{


    public int health;
    public int currentlevel;
    public movementShip shipmgr;
    public int credits;
   



    // Start is called before the first frame update
    void Start()
    {
        cargar();
      
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void cargar()
    {
        
            datosdeljugador playerdata = SistemaDeGuardado.loadPlayerData();
            health = playerdata.health;
            currentlevel = playerdata.currentlevel;
             credits = playerdata.credits;
            this.transform.position = new Vector3(playerdata.position[0], playerdata.position[1], playerdata.position[2]);
            Debug.Log("Dataloaded");

    }
    public void guardar()
    {
        SistemaDeGuardado.saveplayerdata(this);
        Debug.Log("Datasaved");


    }
    public void exitToDesktop()
    {
        guardar();
        Application.Quit();
        Debug.Log("exit");


    }
    public void ExitToMenu()
    {

        shipmgr = new movementShip();
        Time.timeScale = 1;
        guardar();
        SceneManager.LoadScene("MenuPrincipal");
    }
 
}
