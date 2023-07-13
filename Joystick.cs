using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickCharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public Joystick joystick; 

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveInput = joystick.Horizontal; 

        
        Vector2 moveVelocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        
        rb.velocity = moveVelocity;
    }
}

