using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstacal;

    private float spawnTime;
    public float startTime;
    public float minusTime;
    public float minTime = 0.75f;

 
    void Update()
    {
        if (spawnTime <= 0)
        {
            Instantiate(obstacal, transform.position, Quaternion.identity);
            spawnTime = startTime;

            if (startTime > minTime)
            {
                startTime -= minusTime;
            }
        }
        else
        {
            spawnTime -= Time.deltaTime;
        }
    }
}
