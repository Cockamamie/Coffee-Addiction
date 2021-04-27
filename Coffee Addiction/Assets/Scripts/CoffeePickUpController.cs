using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeePickUpController : MonoBehaviour
{
    private bool isPickUpAllowed;
    private const float HealingAmount = 20;
    [SerializeField] private PlayerHealth playerHealthScript;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isPickUpAllowed)
            PickUp();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            isPickUpAllowed = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            isPickUpAllowed = false;
    }

    private void PickUp()
    {
        Destroy(gameObject);
        playerHealthScript.IncreaseHealth(HealingAmount);
    }
}
