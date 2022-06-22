using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ingamemenu : MonoBehaviour
{
  [SerializeField] private  GameObject menu;
    [SerializeField] private GameObject UI;
    [SerializeField] private bool paused;

    // Start is called before the first frame update
    void Start()
    {
        unpause();
    }

    // Update is called once per frame
    void Update()
    {

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
    Time.timeScale = 0;
    paused = true;
    UI.SetActive(false);
        Cursor.visible = true;


}
  public void unpause()
{
    menu.SetActive(false);
   
    Time.timeScale = 1;
    paused = false;
    UI.SetActive(true);
        Cursor.visible = true;


    }
    public void exitToDesktop()
    {

        Application.Quit();
        Debug.Log("exit");


    }
    public void ExitToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuPrincipal");
    }
    public void goToOrit()
    {
        SceneManager.LoadScene("Sistema1");
    }
}
