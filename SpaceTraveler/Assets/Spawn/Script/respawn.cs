using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public GameObject creditos;
    public GameObject[] creditosList;

    private void Update()
    {
        creditosList = GameObject.FindGameObjectsWithTag("caja");
        if (creditosList.Length == 0) creditosSpawn();
        Debug.Log(creditosList.Length);
    }

    void creditosSpawn()
    {
        for (int i = 0; i < 5; i++)
        {
            Vector2 randomSpawn = new Vector2(Random.Range(-54000f, 58000f), Random.Range(-57000, 54000));
            Instantiate(creditos, randomSpawn, transform.rotation);
        }
    }
}
