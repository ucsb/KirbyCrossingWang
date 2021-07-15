using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoMovement : MonoBehaviour
{
    public GameObject tornadoPrefab;
    private float timeCounter = 0;
    
    float movementSpeed;
    float movementX;
    float movementY;

    // tornado array
    public GameObject[] tornados;

    // Start is called before the first frame update
    void Start()
    {
        CreateTornado();
        tornados = GameObject.FindGameObjectsWithTag("Tornado");

        movementSpeed = 1;
        movementX = 0.5f;
        movementY = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * movementSpeed;

        // loops through tornado array
        foreach (GameObject tornado in tornados)
        {
            // circular movement
            float x = Mathf.Cos(timeCounter) * movementX;
            float y = 0;
            float z = Mathf.Sin(timeCounter) * movementY;

            // add cirular motion vector to current position
            tornado.transform.position += new Vector3(x, y, z);
        }
    }

    void CreateTornado()
    {
        Vector3 spawnLocation1 = new Vector3(-20, 5, -80);
        Vector3 spawnLocation2 = new Vector3(40, 5, 20);

        // instantiate 2 tornados
        Instantiate(tornadoPrefab, spawnLocation1, Quaternion.identity);
        Instantiate(tornadoPrefab, spawnLocation2, Quaternion.identity);
    }
}
