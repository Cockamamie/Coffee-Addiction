using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Image bar;
    public Sprite greenBar;
    public Sprite yellowBar;
    public Sprite redBar;
    public void SetHealth(float health)
    {
        slider.value = health;
        if (slider.value > 60)
            bar.sprite = greenBar;
        if (slider.value <= 60 && slider.value > 20)
            bar.sprite = yellowBar;
        if (slider.value <= 20)
            bar.sprite = redBar;
    }

    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        SetHealth(health);
    }
}
