using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed;

    private Vector2 movement;

    private void MovementInput()
    {
        var dx = Input.GetAxisRaw("Horizontal");
        var dy = Input.GetAxisRaw("Vertical");
        movement = new Vector2(dx, dy).normalized;
    }
    private void FixedUpdate()
    {
        rb.velocity = movement * speed;
    }

    // Update is called once per frame
    private void Update()
    {
        MovementInput();
    }
}
