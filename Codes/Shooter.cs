using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject whatToFire;
    public GameObject gun;
    EnemySpawner mylaneSpawner;
    Animator animator;

    private void Start()
    {
        SetLaneSpawner();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (IsEnemyInLane())
        {
            animator.SetBool("IsAttacking", true);
        }

        else
        {
            animator.SetBool("IsAttacking", false);
        }
    }

    public void SetLaneSpawner()
    {
        EnemySpawner[] spawners = FindObjectsOfType<EnemySpawner>();

        foreach(EnemySpawner spawner in spawners)
        {
            bool isClose = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            if (isClose)
            {
                mylaneSpawner = spawner;
            }
        }
    }

    public bool IsEnemyInLane()
    {
        if (mylaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void Fire()
    {
        Instantiate(whatToFire, gun.transform.position, transform.rotation);
    }
}
