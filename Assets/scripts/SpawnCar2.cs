using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar2 : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public int obstacleIndex;
    private float spawnRangeX = 63;
    private float spawnPosZ = -1636;
    private float startDelay = .4f;
    private float spawnInterval = 1f;

  // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObstacle", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomObstacle()
    {
        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), -305, spawnPosZ);

        Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, obstaclePrefabs[obstacleIndex].transform.rotation);  
    }
}
