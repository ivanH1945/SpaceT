using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{


    public int health;
    public int currentlevel;
    public movementShip shipmgr;
    [SerializeField]
    private GameObject planet1;



    // Start is called before the first frame update
    void Start()
    {
        cargar();
        planet1.active = false;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void playerrespawn()
    {

    }
    public void cargar()
    {
        
            datosdeljugador playerdata = SistemaDeGuardado.loadPlayerData();
            health = playerdata.health;
            currentlevel = playerdata.currentlevel;
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("planet1")) 
        {
            planet1.SetActive(true);

            planet1.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("planet1"))
        {
            planet1.SetActive(true);

            planet1.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name.Equals("planet1"))
        {
            planet1.SetActive(false);

            planet1.GetComponent<SpriteRenderer>().color = default;
        }
    }
}
