﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMonstor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherObject = collision.gameObject;

        if (otherObject.GetComponent<Hero>())
        {
            GetComponent<Enemy>().Attack(otherObject);
        }
    }
}
