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
        InvokeRepeating(nameof(LoopedHealthUpdater),5,5);
    }

    private void LoopedHealthUpdater()
    {
        const float decreasedAmount = 5;
        DecreaseHealth(decreasedAmount);
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            DecreaseHealth(5);
    }

    private void DecreaseHealth(float amount)
    {
        currentHealth -= amount;
        healthBar.SetHealth(currentHealth);
    }

    public void IncreaseHealth(float amount)
    {
        currentHealth += amount;
        healthBar.SetHealth(currentHealth);
    }
}
