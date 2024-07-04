using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

   
    public float minX;
    public float maxX;

    
    public float Interval = 2f;

    void Start()
    {
        
        InvokeRepeating("SpawnEnemy", 0f, Interval);
    }

    void SpawnEnemy()
    {
        
        float spawnX = Random.Range(minX, maxX);
        Vector3 spawnPosition = new Vector3(spawnX, transform.position.y, 0f);

        Debug.Log("Spawning object at position: " + spawnPosition);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
    
}
