using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spider : MonoBehaviour
{
    public float life = 6f;

    void Awake()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Projectile"))
        {

            life -= 1;
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(1);
        }
    }

    private void Update()
    {
        if(life <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        GetComponent<LootBag>().InstantiateLoot(transform.position);
    }
}
