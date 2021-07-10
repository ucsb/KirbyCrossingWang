using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevelManager : MonoBehaviour
{
    public GameObject waterPlanePrefab;
    public float playedTime;
    public float waterHeight;
    private float startWaterHeight = -0.5f;
    private float maxWaterHeight = -0.01f;
    private GameObject waterPlane;

    private bool risingWater = true;

    // Start is called before the first frame update
    void Start()
    {
        CreateWaterLevel();
        waterPlane = GameObject.FindGameObjectWithTag("Water Plane");
        waterHeight = waterPlane.transform.position.y;
        
        // change water level repeatedly
        InvokeRepeating("ChangeWaterLevel", 0, 0.05f);
    }

    // Update is called once per frame
    void Update()
    {
        // get water height
        waterHeight = waterPlane.transform.position.y;
    }

    void ChangeWaterLevel()
    {
        // if water is at max height or is going down
        if (waterHeight == maxWaterHeight || !risingWater)
        {
            DecreaseWaterLevel();
        }
        else if (waterHeight == startWaterHeight || risingWater)
        {
            IncreaseWaterLevel();
        }
    }

    void IncreaseWaterLevel()
    {
        Vector3 endLocation = new Vector3(waterPlane.transform.position.x, maxWaterHeight, waterPlane.transform.position.z);

        // move water plane up
        waterPlane.transform.position = Vector3.MoveTowards(waterPlane.transform.position, endLocation, Time.deltaTime / 10);

        // should the water be rising
        risingWater = !(waterHeight == maxWaterHeight);   
    }

    void DecreaseWaterLevel()
    {
        Vector3 endLocation = new Vector3(waterPlane.transform.position.x, startWaterHeight, waterPlane.transform.position.z);

        // move water plane up
        waterPlane.transform.position = Vector3.MoveTowards(waterPlane.transform.position, endLocation, Time.deltaTime / 10);

        // should the water be rising
        risingWater = (waterHeight == startWaterHeight);
    }

    void CreateWaterLevel()
    {
        Instantiate(waterPlanePrefab, new Vector3(0, startWaterHeight, 0), Quaternion.identity);
    }


}
