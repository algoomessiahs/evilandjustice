using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    float currentSpeed = 1f;

    GameObject currentTarget;

    public int scoreValue = 50;


    public void Awake()
    {
        FindObjectOfType<LevelController>().EnemySpawned();
    }

    public void OnDestroy()
    {
        LevelController levelController = FindObjectOfType<LevelController>();

        if (levelController == null) { return; }

        levelController.EnemyKilled();
    }

    public void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
        UpdateAnimationState();
    }

    public void UpdateAnimationState()
    {
        if (!currentTarget)
        {
            GetComponent<Animator>().SetBool("IsAttacking", false);
        }
    }

    public void SetSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("IsAttacking", true);
        currentTarget = target;
    }

    public void StrikeCurrentTarget(float damage)
    {
        if (!currentTarget) { return; }

        Health health = currentTarget.GetComponent<Health>();

        if (health)
        {
            health.DealDamage(damage);
        }
    }

    public void EatingSoundEffect(AudioClip eatingSoundEffect)
    {
        AudioSource.PlayClipAtPoint(eatingSoundEffect, Camera.main.transform.position, 0.25f);
    }
}
