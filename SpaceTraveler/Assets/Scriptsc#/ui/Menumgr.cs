using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menumgr : MonoBehaviour
{
    [SerializeField]
    GameObject settingsmenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void explore()
    {
        SceneManager.LoadScene("sistema1");
    }
    public void settings() 
    {
        settingsmenu.SetActive(false);
    }
    

}
