using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    float maxX;

    public GameObject[] Candies;
    void Start()
    {
        SpawnCandy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCandy()
    {
        int randomCandy = Random.Range(0, Candies.Length);
        Instantiate(Candies[randomCandy], transform.position, transform.rotation);
    }
}
