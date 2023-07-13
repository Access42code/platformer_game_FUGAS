using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveInput = Input.GetAxis("Horizontal"); 

        
        Vector2 moveVelocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        
        rb.velocity = moveVelocity;
    }
}

