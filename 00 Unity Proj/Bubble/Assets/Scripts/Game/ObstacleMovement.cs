using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleMovement : MovableProp
{
    private Obstacle obstacle; // Obstacle.cs

    // Override Awake() in MovableProp.cs
    protected override void Awake()
    {
        // ===== Target =====
        base.Awake(); // Target initialized in base class

        // ===== Obstacle =====
        // obstacle = Obstacle.Instance; // Access Obstacle.cs
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
    
    // public override void Move()
    // {
    //     // Move the Rigidbody to the next point
    //     rb.velocity = new Vector2 (speedX, 0f);
    // }
    
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
        // Calculates the prop's destination to move its Rigidbody
        // at a constant speed with no acceleration
        // Vector2 destination = new Vector2(rb.position.x + currentPos.x * speedX * Time.fixedDeltaTime, rb.position.y + currentPos.y * speedY * Time.fixedDeltaTime);
        // rb.MovePosition(destination);
        
        // speedY = -speedY; // Reverse the Y-axis movement
        // // This is because positive velocity
        // // is UP and negative velocity is DOWN
        
        Vector2 velocity = new Vector2(speedX, -speedY);
        Vector2 destination = rb.position + velocity * Time.fixedDeltaTime;
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
