using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D othercollision)
    {
        GameObject otherObject = othercollision.gameObject;

        if (otherObject.GetComponent<ScareCrow>())
        {
            GetComponent<Animator>().SetTrigger("JumpTrigger");
        }

        else if (otherObject.GetComponent<Hero>())
        {
            GetComponent<Enemy>().Attack(otherObject);
        }
    }
}
