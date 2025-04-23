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
        obstacle = Obstacle.Instance; // Access Obstacle.cs
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
    
    public override void Move()
    {
        // Move the Rigidbody to the next point
        rb.velocity = new Vector2 (speedX, 0f);
    }
    
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
