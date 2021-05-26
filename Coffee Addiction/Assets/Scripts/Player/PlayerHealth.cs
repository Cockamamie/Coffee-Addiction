using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private const int MaxHealth = 100;
    private int currentHealth;
    public UnityEvent<int> OnHealthChange;

    private void Start()
    {
        currentHealth = SceneManager.GetActiveScene().buildIndex <=  1 ? MaxHealth : OnSceneTransit.hp;
        InvokeRepeating(nameof(LoopedHealthUpdater),5,5);
    }

    private void LoopedHealthUpdater()
    {
        const int decreasedAmount = 10;
        DecreaseHealth(decreasedAmount);

    }

    private void Update()
    {
        if (currentHealth >= 100)
            currentHealth = 100;
        if (currentHealth > 0) return;
        Destroy(gameObject);
        SceneManager.LoadScene(0);
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
