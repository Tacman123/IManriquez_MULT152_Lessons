using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spider : MonoBehaviour
{
    public float life = 1;

    void Awake()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Projectile"))
        {
            
            Destroy(collision.gameObject);
        }
        else if (collision.collider.CompareTag("DestructibleWall"))
            Destroy(collision.gameObject);
    }
}
