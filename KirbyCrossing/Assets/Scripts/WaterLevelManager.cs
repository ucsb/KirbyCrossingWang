using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevelManager : MonoBehaviour
{
    public GameObject waterPlanePrefab;
    public float playedTime;
    private float waterHeight;
    private float maxWaterHeight = 10;
    private GameObject waterPlane;



    // Start is called before the first frame update
    void Start()
    {
        CreateWaterLevel();
        waterPlane = GameObject.FindGameObjectWithTag("Water Plane");
        waterHeight = waterPlane.transform.position.y;

        StartCoroutine(RaiseWaterLevelRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        // set water plane height
        waterHeight = waterPlane.transform.position.y;
    }

    IEnumerator RaiseWaterLevelRoutine()
    {
        // wait for 5 second
        yield return new WaitForSeconds(5);

        while (waterHeight < maxWaterHeight)
        {
            waterPlane.transform.Translate(Vector3.up);
        }
        
    }

    void CreateWaterLevel()
    {
        Instantiate(waterPlanePrefab, new Vector3(0, -0.5f, 0), Quaternion.identity);
    }


}
