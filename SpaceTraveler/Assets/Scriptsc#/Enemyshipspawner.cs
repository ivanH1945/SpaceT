using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemyshipspawner : MonoBehaviour
{
    [SerializeField] private float maxSpawnAreaX;
    [SerializeField] private float maxSpawnAreaY;
    [SerializeField] private float minSpawnAreaX;
    [SerializeField] private float minSpawnAreaY;
    
    Vector2 randomSpawnpoint;
    GameObject ship;
    [SerializeField]GameObject[] shipsformations;

    // Start is called before the first frame update
    void Start()
    {
        shipsformations = GameObject.FindGameObjectsWithTag("enemyship");
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Spawn() 
    {
        foreach (GameObject shipformation in shipsformations) 
        {

            float randomx = Random.Range(minSpawnAreaX, maxSpawnAreaX);
            float randomy = Random.Range(minSpawnAreaY, maxSpawnAreaY);

            shipformation.transform.position=new Vector3(randomx,randomy,-394);
        }

    }
}
