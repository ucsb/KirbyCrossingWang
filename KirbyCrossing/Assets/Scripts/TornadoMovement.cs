using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoMovement : MonoBehaviour
{
    public GameObject tornadoPrefab;

    // Start is called before the first frame update
    void Start()
    {
        CreateTornado();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateTornado()
    {
        Vector3 spawnLocation1 = new Vector3(-40, 5, -60);
        Vector3 spawnLocation2 = new Vector3(40, 5, 60);

        // instantiate 2 tornados
        Instantiate(tornadoPrefab, spawnLocation1, Quaternion.identity);
        Instantiate(tornadoPrefab, spawnLocation2, Quaternion.identity);
    }
}
