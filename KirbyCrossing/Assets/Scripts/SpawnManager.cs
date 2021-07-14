using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    private float startDelay = 1;
    private float spawnInterval = 0.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandom", startDelay, spawnInterval);
    }
    private float spawnRangeX = 24;
    private float spawnRangeZ = 10;
    public GameObject firePrefab; 
    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandom(){
        Vector3 spawnPos = new Vector3(Random.Range(0, spawnRangeX), 0, Random.Range(-1, spawnRangeZ));
            Instantiate(firePrefab, spawnPos, Quaternion.Euler(-90,0,0));
    }
}
