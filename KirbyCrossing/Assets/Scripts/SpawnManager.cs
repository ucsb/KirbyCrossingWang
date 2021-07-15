using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    private float startDelay = 1;
    private float spawnInterval = 0.5f;

    private float spawnRangeX = 24;
    private float spawnRangeZ = 10;
    public GameObject firePrefab;

    void Start()
    {
        InvokeRepeating("SpawnRandomRight", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomLeft", startDelay*10, spawnInterval);
        InvokeRepeating("SpawnRandomBack", startDelay*15, spawnInterval);
    }
    
    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomRight(){
        Vector3 spawnPos = new Vector3(Random.Range(0, spawnRangeX), 0, Random.Range(-1, spawnRangeZ));
        Instantiate(firePrefab, spawnPos, Quaternion.Euler(-90,0,0));
    }
    void SpawnRandomLeft(){
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, 0), 0, Random.Range(-1, spawnRangeZ));
        Instantiate(firePrefab, spawnPos, Quaternion.Euler(-90,0,0));
    }
    void SpawnRandomBack(){
        Vector3 spawnPos = new Vector3(Random.Range(-5, 5), 0, Random.Range(-35, 20));
        Instantiate(firePrefab, spawnPos, Quaternion.Euler(-90,0,0));
    }

 
     //IEnumerator ExecuteAfterTime(float time)
    //{
      //  yield return new WaitForSeconds(time);
    //}
    private bool isCoroutineExecuting = false;
 
    IEnumerator ExecuteAfterTime(float time)
    {
        if (isCoroutineExecuting)
             yield break;
 
        isCoroutineExecuting = true;
        yield return new WaitForSeconds(time);
        isCoroutineExecuting = false;
    }

   
   // void Update()
    //{
        // Cancel only the LaunchProjectile invoke
      //  if (Input.GetButton("Fire1"))
        //    CancelInvoke("LaunchProjectile");
    //}
//}

}

