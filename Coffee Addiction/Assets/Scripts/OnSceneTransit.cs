using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSceneTransit : MonoBehaviour
{
    public static int hp;
    [SerializeField] private PlayerHealth playerHealth;
    

    private void Start()
    {
        playerHealth.OnHealthChange.AddListener(health =>
        {
            hp = health;
        });
    }
}
