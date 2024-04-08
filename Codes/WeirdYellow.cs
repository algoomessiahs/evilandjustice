using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeirdYellow : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D othercollision)
    {
        GameObject otherObject = othercollision.gameObject;

        if (otherObject.GetComponent<Hero>())
        {
            GetComponent<Enemy>().Attack(otherObject);
        }
    }

    public void GetDestroyed()
    {
        Destroy(gameObject);
    }
}
