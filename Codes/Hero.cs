using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public AudioClip tauntSound;
    public int starCost = 100;
    public void AddStars(int amount)
    {
        FindObjectOfType<StarDisplay>().AddStars(amount);
    }

    public int GetStarCost()
    {
        return starCost;
    }

    public void PlayTauntSound()
    {
        if (tauntSound)
        {
            AudioSource.PlayClipAtPoint(tauntSound, Camera.main.transform.position, 0.75f);
        }
    }














    // Enemy stuff


    float currentSpeed = 1f;

    GameObject currentTarget;

    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
        UpdateAnimationState();
    }

    private void UpdateAnimationState()
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
