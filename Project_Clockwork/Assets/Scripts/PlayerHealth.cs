using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static event Action OnPlayerDamaged;
    public static event Action OnPlayerDeath;
    public float damageCooldown = 3f;
    public float health, maxHealth;

    public bool canTakeDamage = true;
    private bool damageTaken = false;

    void Start()
    {
        health = maxHealth;        
    }

    private void Update()
    {
        Debug.Log("Can Be Damaged. . .");
        if (damageTaken) 
        {
            StartCoroutine(DamageCooldown());
        }
    }

    public void TakeDamage(float amount)
    {
        if(canTakeDamage)
        {
            health -= amount;
            OnPlayerDamaged?.Invoke();
            damageTaken = true;
            Debug.Log("Damage Taken. . .");
        }

        if (health <= 0)
        {            
            health = 0;
            Debug.Log("You're Dead!");
            OnPlayerDeath?.Invoke();            
        }
    }

    IEnumerator DamageCooldown()
    {
        Debug.Log("Damage Cooldown begins . . .");
        canTakeDamage = false;
        yield return new WaitForSeconds(damageCooldown);
        canTakeDamage = true;
        damageTaken = false;
        Debug.Log("Damage Reset . . .");
    }
}
