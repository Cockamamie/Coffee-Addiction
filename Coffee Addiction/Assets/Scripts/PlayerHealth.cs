using System.Timers;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private const float MaxHealth = 100;
    public float currentHealth;

    public HealthBar healthBar;
    private void Start()
    {
        currentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
        
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            DecreaseHealth(1);
    }

    private void DecreaseHealth(float amount)
    {
        currentHealth -= amount;
        healthBar.SetHealth(currentHealth);
    }

    private void IncreaseHealth(float amount)
    {
        currentHealth += amount;
        healthBar.SetHealth(currentHealth);
    }
}
