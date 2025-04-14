using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // ===== Script References =====
    private Player player; // Player.cs
    private PlayerControls playerControls; // PlayerControls.cs
    private Target target; // Target.cs
    // =============================

    // ===== Variables/Components =====
    private Rigidbody2D playerRB; // Rigidbody Component
    private Vector2 startPos; // Starting Position (set once)
    private Vector2 playerPos; // Current Position (set continuously)
    private Vector2 newPos; //  New Position (set continuously)
    private Vector2 targetPos; // Target's Position
    private float moveSpeed; // Horizonal Speed
    private float floatSpeed; // Vertical Speed
    private GameObject targetGO; // Target Game Object
    // ================================

    private void Awake()
    {
        // ===== Player =====
        player = Player.Instance; // Access Player.cs
        playerControls = Player.Controls; // Access movement controls

        // ===== Target =====
        target = Target.Instance; // Access Target.cs
    }
    
    void Start()
    {
        GetPlayerInfo(); // Get the Player's info
        GetTargetInfo(); // Get the Target's info
        
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
        floatSpeed = player.GetPlayerSpeedY(); // Vertical Speed

        // Debug this info
        Debug.Log($"PlayerMovement.cs > GetPlayerInfo(): Player's starting position is ({startPos.x}, {startPos.y})");
        Debug.Log($"PlayerMovement.cs > GetPlayerInfo(): Player's horizontal speed is {moveSpeed}");
        Debug.Log($"PlayerMovement.cs > GetPlayerInfo(): Player's vertical speed is {floatSpeed}");
    }

    private void GetTargetInfo()
    {
        // Get the following information about the Target
        targetPos = target.GetTargetPosition(); // Target's Position
        
        // Debug this info
        Debug.Log($"PlayerMovement.cs > GetTargetInfo(): Target's position is {targetPos}");
    }

    void Update()
    {
        // Speed Vertical
        float step = floatSpeed * Time.deltaTime;
        
        // Update the X coordinate based on player input
        float newX = playerControls.MoveHorizontal.Move.ReadValue<Vector2>().x;
        
        // Update the Y coordinate | Move player towards target at constant speed
        float newY = Vector2.MoveTowards(new Vector2(0, playerPos.y), new Vector2(0, targetPos.y), step).y;
        
        // Set the Player's position to the new coordinates
        newPos = new Vector2(newX, newY);
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