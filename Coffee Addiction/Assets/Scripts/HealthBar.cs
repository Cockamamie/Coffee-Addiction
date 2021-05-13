using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Image healthBar;
    [SerializeField] private Sprite yellowBar;
    [SerializeField] private Sprite redBar;
    [SerializeField] private PlayerHealth playerHealth;

    private void Start()
    {
        playerHealth.OnHealthChange.AddListener(health =>
        {
            if (health <= 60 && health > 20)
                healthBar.sprite = yellowBar;
            if (health <= 20)
                healthBar.sprite = redBar;
            slider.value = health;
        });
    }
}
