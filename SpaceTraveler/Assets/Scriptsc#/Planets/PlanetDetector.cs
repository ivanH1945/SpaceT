using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetDetector : MonoBehaviour
{
    [SerializeField] bool onOrbit;
    [SerializeField] GameObject orbitdisplay;
    [SerializeField] string sceneToLoadName;
    void Start()
    {
        orbitdisplay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ship")) 
        {
            orbitdisplay.SetActive(true);
            Cursor.visible = true;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("ship"))
        {
            orbitdisplay.SetActive(false);
            Cursor.visible = false;
        }
    }
    public void landInAPlanet() 
    {
        SceneManager.LoadScene(sceneToLoadName);
    }
}
