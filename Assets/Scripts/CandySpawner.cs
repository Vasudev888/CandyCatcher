using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    public static CandySpawner instance;

    [SerializeField]
    float maxX;

    [SerializeField]
    float spawnInterval;

    public GameObject[] Candies;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        //SpawnCandy();
        StartSpawningCandy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCandy()
    {
        int randomCandy = Random.Range(0, Candies.Length);
        float randomX = Random.Range(-maxX, maxX);
        Vector3 randomPos = new Vector3(randomX, transform.position.y, transform.position.z);
        Instantiate(Candies[randomCandy], randomPos, transform.rotation);

    }

    IEnumerator SpawnCandies()
    {
        yield return new WaitForSeconds(2f);

        while(true)
        {
            SpawnCandy();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void  StartSpawningCandy()
    {
        StartCoroutine("SpawnCandies");
    }

    public void StopSpawningCandy()
    {
        StopCoroutine("SpawnCandies");
    }
}
