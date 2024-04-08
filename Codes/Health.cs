using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float health = 100f;
    public float destroyAfter = 0f;
    public GameObject enemyDieEffect;

    public AudioClip deathSoundEffect;


    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {

            FindObjectOfType<GameScore>().AddToScore(FindObjectOfType<Enemy>().scoreValue);
            GetComponent<Animator>().SetBool("IsDead", true);
            PlayDeathSoundEffect();
            if (destroyAfter <= 0)
            {
                TriggerDeathEffect();
            }

            Destroy(gameObject, destroyAfter); 
        }
    }

    private void Update()
    {
        if (health <= 0)
        {

            Destroy(gameObject.GetComponent<Rigidbody2D>());
            Destroy(gameObject.GetComponent<BoxCollider2D>());
            Destroy(gameObject.GetComponent<Hero>());
            Destroy(gameObject.GetComponent<Enemy>());
        }
    }

    private void PlayDeathSoundEffect()
    {
        AudioSource.PlayClipAtPoint(deathSoundEffect, Camera.main.transform.position, 0.75f);
    }

    private void TriggerDeathEffect()
    {
        if (!enemyDieEffect)
        {
            Debug.Log("Put something on the death VFX!");
        }

        GameObject deathEffect = Instantiate(enemyDieEffect, transform.position, transform.rotation);
        Destroy(deathEffect, 1.5f);
    }
}
