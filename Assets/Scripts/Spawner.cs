using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstacalPatterns;

    private float spawnTime;
    public float startTime;
    public float minusTime;
    public float minTime = 0.75f;

 
    void Update()
    {
        if (spawnTime <= 0)
        {
            int _random = Random.Range(0, obstacalPatterns.Length);
            Instantiate(obstacalPatterns[_random], transform.position, Quaternion.identity);
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
