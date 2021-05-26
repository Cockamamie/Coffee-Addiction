using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    private const int MaxHealth = 100;
    private int currentHealth;
    public UnityEvent<int> OnHealthChange;

    private void Start()
    {
        currentHealth = MaxHealth;
        InvokeRepeating(nameof(LoopedHealthUpdater),5,5);
    }

    private void LoopedHealthUpdater()
    {
        const int decreasedAmount = 10;
        DecreaseHealth(decreasedAmount);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            DecreaseHealth(5);
    }

    private void DecreaseHealth(int amount)
    {
        currentHealth -= amount;
        OnHealthChange.Invoke(currentHealth);
    }

    public void IncreaseHealth(int amount)
    {
        currentHealth += amount;
        OnHealthChange.Invoke(currentHealth);
    }
}
