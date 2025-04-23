using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // ===== Script References =====
    private Player player; // Player.cs
    private PlayerControls playerControls; // PlayerControls.cs
    // =============================

    // ===== Variables/Components =====
    private Rigidbody2D playerRB; // Rigidbody Component
    private Vector2 startPos; // Starting Position (set once)
    private Vector2 playerPos; // Current Position (set continuously)
    private Vector2 newPos; //  New Position (set continuously)
    private float moveSpeed; // Horizonal Speed
    // ================================

    private void Awake()
    {
        // ===== Player =====
        player = Player.Instance; // Access Player.cs
        playerControls = Player.Controls; // Access movement controls
    }
    
    void Start()
    {
        GetPlayerInfo(); // Get the Player's info
        
        // When the script is called, grab the player's starting
        // position and set it as the current position.
        playerPos = startPos;
        // The player's position will then
        // continuously be updated in Update()
    }

    private void GetPlayerInfo()
    {
        // Get the following information about the Player
        playerRB = player.GetRigidbody2D(); // RigidBody2D
        startPos = player.GetPlayerPosition(); // Starting Position
        moveSpeed = player.GetPlayerSpeedX(); // Horizontal Speed

        // Debug this info
        Debug.Log($"PlayerMovement.cs > GetPlayerInfo(): Player's starting position is ({startPos.x}, {startPos.y})");
        Debug.Log($"PlayerMovement.cs > GetPlayerInfo(): Player's horizontal speed is {moveSpeed}");
    }

    void Update()
    {
        // Update the X coordinate based on player input
        float newX = playerControls.MoveHorizontal.Move.ReadValue<Vector2>().x;
        
        // Set the Player's position to the new coordinates
        newPos = new Vector2(newX, playerPos.y);
        playerPos = newPos;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        // Calculates the player's destination to move
        // the playerRB at a constant speed with no acceleration
        Vector2 destination = new Vector2(playerRB.position.x + playerPos.x * moveSpeed * Time.fixedDeltaTime, playerPos.y);
        playerRB.MovePosition(destination);
    }
}