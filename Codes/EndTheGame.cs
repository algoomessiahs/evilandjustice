using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTheGame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<LivesDisplay>().DecreseHealth();
        Destroy(collision.gameObject);
    }
}
