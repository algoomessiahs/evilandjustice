using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMonstor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D othercollision)
    {
        GameObject otherObject = othercollision.gameObject;

        if (otherObject.GetComponent<Enemy>())
        {
            GetComponent<Hero>().Attack(otherObject);
        }
    }
}
