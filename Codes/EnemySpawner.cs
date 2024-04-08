using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public bool spawnEnemy = true;

    public float spawnAfter = 0f;
    public int numberOfEnemiesToSpawn;
    float minSpawnDelay = 2f;
    float maxSpawnDelay = 7f;
    public Enemy[] enemyToSpawnArray;

    int enemySpawned = 0;

    private void Update()
    {
        if (numberOfEnemiesToSpawn == 0)
        {
            return;
        }

        else
        {

            if (numberOfEnemiesToSpawn == enemySpawned)
            {
                StopSpawning();
            }

        }

    }

    private IEnumerator Start()
    {
        if (PlayerPrefsController.GetDifficulty() == 0)
        {
            minSpawnDelay = 3f + spawnAfter;
            maxSpawnDelay = 9f + spawnAfter;
        }
        else if (PlayerPrefsController.GetDifficulty() == 1)
        {
            minSpawnDelay = 2f + spawnAfter;
            maxSpawnDelay = 7f + spawnAfter;
        }
        else if (PlayerPrefsController.GetDifficulty() == 2)
        {
            minSpawnDelay = 1.8f + spawnAfter;
            maxSpawnDelay = 5f + spawnAfter;
        }
        else if (PlayerPrefsController.GetDifficulty() == 3)
        {
            minSpawnDelay = 1.5f + spawnAfter;
            maxSpawnDelay = 3f + spawnAfter;
        }
        else if (PlayerPrefsController.GetDifficulty() == 4)
        {
            minSpawnDelay = 0.1f + spawnAfter;
            maxSpawnDelay = 2f + spawnAfter;
        }
        while (spawnEnemy)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnEnemy();
        }
    }

    public void StopSpawning()
    {
        spawnEnemy = false;
    }

    void SpawnEnemy()
    {
        var enemyIndex = Random.Range(0, enemyToSpawnArray.Length);

        Spawn(enemyToSpawnArray[enemyIndex]);
    }

    public int EnemySpawned()
    {
        return enemyToSpawnArray.Length;
    }

    private void Spawn(Enemy myEnemy)
    {
        enemySpawned += 1;
        Enemy newEnemy = Instantiate(myEnemy, transform.position, Quaternion.identity) as Enemy;
        newEnemy.transform.parent = transform;
    }

}
