using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public float damage = 1f;
    public float knockbackStrength = 5f;

    PlayerHealth playerHealth;

    private void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Apply damage to the player
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);

            // Apply knockback
            CharacterController playerController = other.gameObject.GetComponent<CharacterController>();
            if (playerController != null)
            {
                Vector3 direction = (other.transform.position - transform.position).normalized;
                StartCoroutine(ApplyKnockback(playerController, direction));
            }
        }
    }

    private IEnumerator ApplyKnockback(CharacterController playerController, Vector3 direction)
    {
        float knockbackDuration = 0.5f; // Duration of the knockback
        float timer = 0f;

        while (timer < knockbackDuration)
        {
            playerController.Move(direction * knockbackStrength * Time.deltaTime);
            timer += Time.deltaTime;
            yield return null;
        }
    }
}
