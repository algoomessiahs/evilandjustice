using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScareCrow : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();

        if (enemy)
        {
            
        }
    }
}
