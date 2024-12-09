using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Script : MonoBehaviour
{
    public float cooldown = 2f;
    private bool canShoot = true;

    public Transform projectileSpawnPoint;
    public GameObject projectilePrefab;
    public float projectileSpeed = 10;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && canShoot)
        {
            StartCoroutine(ShootWithDelay());           
        }
    }

    IEnumerator ShootWithDelay()
    {
        canShoot = false;
        ShootProjectile();
        yield return new WaitForSeconds(cooldown);
        canShoot = true;
    }

    void ShootProjectile()
    {
        var projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
        projectile.GetComponent<Rigidbody>().velocity = projectileSpawnPoint.forward * projectileSpeed;
    }
}
