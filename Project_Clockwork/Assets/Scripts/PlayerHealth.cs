using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 8f;
    public float Health;
    public Image healthBar;

    void Start()
    {
        Health = maxHealth;
        UpdateHealthBar();
    }

    public void TakeDamage(float damage)
    {
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }
        UpdateHealthBar();
    }

    public void Heal(float amount)
    {
        Health += amount;
        if (Health > maxHealth)
        {
            Health = maxHealth;
        }
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        healthBar.fillAmount = Health / maxHealth;
    }
}
