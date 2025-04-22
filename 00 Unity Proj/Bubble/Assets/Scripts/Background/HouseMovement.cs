using System;
using UnityEngine;

public class HouseMovement : MonoBehaviour
{
    // ===== Script References =====
    private House house; // House.cs
    private Target target; // Target.cs
    // =============================

    // ===== Variables/Components =====
    private Rigidbody2D houseRB; // Rigidbody Component
    private Vector2 startPos; // Starting Position (set once)
    private Vector2 housePos; // Current Position (set continuously)
    private Vector2 newPos; //  New Position (set continuously)
    private Vector2 targetPos; // Target's Position
    private float houseSpeed; // Horizonal Speed
    // ================================

    private void Awake()
    {
        // ===== Player =====
        house = House.Instance; // Access Player.cs

        // ===== Target =====
        target = Target.Instance; // Access Target.cs
    }
    
    void Start()
    {
        GetHouseInfo(); // Get the House's info
        GetTargetInfo(); // Get the Target's info
        
        // When the script is called, grab the player's starting
        // position and set it as the current position.
        housePos = startPos;
        // The player's position will then
        // continuously be updated in Update()
    }

    private void GetHouseInfo()
    {
        // Get the following information about the Player
        houseRB = house.GetRigidbody2D(); // RigidBody2D
        startPos = house.GetHousePosition(); // Starting Position
        houseSpeed = house.GetHouseSpeed(); // Horizontal Speed

        // Debug this info
        Debug.Log($"HouseMovement.cs > GetHouseInfo(): House's starting position is ({startPos.x}, {startPos.y})");
        Debug.Log($"HouseMovement.cs > GetHouseInfo(): House's movement speed is {houseSpeed}");
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
        float step = houseSpeed * Time.deltaTime;
        
        // Update the X coordinate based on player input
        // float newX = playerControls.MoveHorizontal.Move.ReadValue<Vector2>().x;
        
        // Update the Y coordinate | Move player towards target at constant speed
        float newY = Vector2.MoveTowards(new Vector2(0, housePos.y), new Vector2(0, targetPos.y), step).y;
        
        // Set the Player's position to the new coordinates
        newPos = new Vector2(housePos.x, newY);
        housePos = newPos;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        // Calculates the player's destination to move
        // the playerRB at a constant speed with no acceleration
        Vector2 destination = new Vector2(houseRB.position.x + housePos.x * houseSpeed * Time.fixedDeltaTime, housePos.y);
        houseRB.MovePosition(destination);
    }
}