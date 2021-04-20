using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Image healthBar;
    public Sprite yellowBar;
    public Sprite redBar;
    public void SetHealth(float health)
    {
        slider.value = health;
        if (slider.value <= 60 && slider.value > 20)
            healthBar.sprite = yellowBar;
        if (slider.value <= 20)
            healthBar.sprite = redBar;
    }

    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        SetHealth(health);
    }
}
