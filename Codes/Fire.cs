using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float speed = 1f;
    public float damage = 50f;
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var health = otherCollider.GetComponent<Health>();
        var enemy = otherCollider.GetComponent<Enemy>();

        if (health && enemy)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }
    }
}
