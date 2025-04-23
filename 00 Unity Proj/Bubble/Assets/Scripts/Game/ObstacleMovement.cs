using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleMovement : MovableProp
{
    // ===== Script References =====
    private Obstacle obstacle; // Obstacle.cs
    // =============================

    // Override Awake() in MovableProp.cs
    protected override void Awake()
    {
        // ===== Target =====
        base.Awake(); // Target initialized in base class

        // ===== Obstacle =====
        obstacle = GetComponent<Obstacle>(); // Access Obstacle.cs
    }
    
    // Get the following information about the Obstacle
    public override void GetPropInfo()
    {
        propName = obstacle.GetObstacleName();
        rb = obstacle.GetRigidbody2D(); // RigidBody2D
        startPos = obstacle.GetObstaclePosition(); // Starting Position
        speedX = obstacle.GetObstacleSpeedX(); // Horizontal Speed
        speedY = obstacle.GetObstacleSpeedY(); // Vertical Speed

        // Debug info about prop (called from MovableProp.cs)
        DebugPropInfo();
    }
    
    // Update the prop's position continuously
    public override void UpdatePosition()
    {
        base.UpdatePosition(); // Y-position updated in base class
        
        // Update the X-position via the Rigidbody velocity
        //rb.velocity = new Vector2(speedX, rb.velocity.y);

        // Update the current position
        currentPos = new Vector2(rb.position.x, currentPos.y);
    }

    // Move the prop (call this in FixedUpdate())
    public override void Move()
    {
        // Calculate the new position
        Vector2 velocity = new Vector2(speedX, -speedY);
        // The Y-axis movement is reversed because positive
        // velocity is UP and negative velocity is DOWN,
        // and DOWNWARDS is where the Target is
        
        // Calculate the destination position
        Vector2 destination = rb.position + velocity * Time.fixedDeltaTime;
        
        // Move the Rigidbody to the new position
        rb.MovePosition(destination);
    }
    
    // Collision with Scene Barriers
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Barrier"))
        {
            // Reverse the movement speed in
            // the opposite direction
            speedX = -speedX;
        }
    }
}
