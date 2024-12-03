using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float life = 1;
    public int damage = 1; // Amount of damage the projectile deals

    void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
             // Destroy the projectile
            Destroy(gameObject);
        }
    }
}
