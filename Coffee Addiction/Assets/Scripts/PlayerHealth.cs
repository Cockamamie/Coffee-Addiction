using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private const float MaxHealth = 100;
    public float currentHealth;
    [SerializeField] private HealthBar healthBar;
    private void Start()
    {
        currentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
        InvokeRepeating(nameof(LoopedHealthUpdater),5,5);
    }

    private void LoopedHealthUpdater()
    {
        const float decreasedAmount = 10;
        DecreaseHealth(decreasedAmount);
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            DecreaseHealth(5);
        /*if (currentHealth == 0)
            Destroy(gameObject);*/
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
