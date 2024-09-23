using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeScript : MonoBehaviour
{
    public Transform projectileSpawnPoint;
    public GameObject SmokePrefab;
    public float projectileSpeed = 10;

    void Start()
    {
        InvokeRepeating("Lift", .5f, .5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Lift()
    {
        Debug.Log("Smoke!");
        var projectile = Instantiate(SmokePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
        projectile.GetComponent<Rigidbody>().velocity = projectileSpawnPoint.up * projectileSpeed;
    }
}
