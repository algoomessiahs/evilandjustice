using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public GameObject levelComplete;

    public GameObject gameLose;

    public AudioClip levelCompleteSound;

    public AudioClip gameLoseSound;

    public AudioSource audioSource;

    int numberOfEnemies = 0;

    bool timesHasFinished = false;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        levelComplete.SetActive(false);
        gameLose.SetActive(false);
    }

    public void EnemySpawned()
    {
        numberOfEnemies++;
    }


    public void SetGameLoseTrue()
    {
        gameLose.SetActive(true);
        audioSource.PlayOneShot(gameLoseSound);
        Time.timeScale = 0;
    }

    public void EnemyKilled()
    {
        numberOfEnemies--;

        if (numberOfEnemies <= 0 && timesHasFinished)
        {
            ShowLevelComplete();
        }
    }

    void ShowLevelComplete()
    {
        levelComplete.SetActive(true);
        audioSource.PlayOneShot(levelCompleteSound, 1f);
        Time.timeScale = 0;

    }
    public void LevelTimerFinished()
    {
        timesHasFinished = true;
        StopSpawners();
    }

    private void StopSpawners()
    {
        EnemySpawner[] spawnerArray = FindObjectsOfType<EnemySpawner>();

        foreach (EnemySpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }

}
