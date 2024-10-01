using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float life = 1;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            GetComponent<LootBag>().InstantiateLoot(transform.position);
            Destroy(collision.gameObject);
        }
        else if (collision.collider.CompareTag("DestructibleWall"))
            Destroy(collision.gameObject);
    }
}
