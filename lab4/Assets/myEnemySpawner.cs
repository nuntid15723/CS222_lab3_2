using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myEnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spawnPoint;
    public GameObject enemyPrefab;
    public float secondsBetweenSpawns;
    float secondsSinceLastSpawn;

    // Start is called before the first frame update
    void Start()
    {
        secondsSinceLastSpawn = 0;
        spawnPoint.transform.position = transform.position;
        spawnPoint.transform.position = transform.position;
    }

    //Fixed update happens the same number of times for all players, so it's a good place for gameplay critical things.
    private void FixedUpdate()
    {
        secondsSinceLastSpawn += Time.fixedDeltaTime;
        if (secondsSinceLastSpawn >= secondsBetweenSpawns)
        {
            Instantiate(enemyPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
            secondsSinceLastSpawn = 0;
        }
    }
}

