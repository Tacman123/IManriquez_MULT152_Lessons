using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenaderThrower : MonoBehaviour
{
    public Transform projectileSpawnPoint;
    public float throwForce = 40f;
    public GameObject grenadePrefab;

    public float cooldown = 2f;
    private bool canThrow = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1) && canThrow)
        {
            StartCoroutine(ThrowWithDelay());
        }
    }

    IEnumerator ThrowWithDelay()
    {
        canThrow = false;
        ThrowGrenade();
        yield return new WaitForSeconds(cooldown);
        canThrow = true;
    }

    void ThrowGrenade()
    {
        GameObject grenade = Instantiate(grenadePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
        Rigidbody rb = grenade.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * throwForce, ForceMode.VelocityChange);

        
    }
}
