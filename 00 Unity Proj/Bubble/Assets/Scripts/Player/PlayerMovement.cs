using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // ===== Script References =====
    public TargetInfo targetInfo; // TargetInfo.cs
    public PlayerInfo playerInfo; // PlayerInfo.cs
    private PlayerControls playerControls; // PlayerControls.cs
    // =============================

    // ===== Variables/Components =====
    private Rigidbody2D playerRB; // Player's Rigidbody Component
    private Vector2 startPos; // Player's Starting Location
    private Vector2 playerPos; // Player's Current Location
    private Vector2 newPos; // Player's Next Location
    private Vector2 targetPos; // Target's Location
    private float moveSpeed; // Player's Horizontal Speed (Player-controlled)
    private float floatSpeed; // Player's Vertical Speed (Automatic)
    private GameObject playerGO;
    private GameObject targetGO;
    // ================================

    private void Awake()
    {
        // ===== Player =====
        playerGO = GameObject.Find("Player"); // Assign GameObject
        playerInfo = playerGO.GetComponent<PlayerInfo>(); // Access PlayerInfo.cs
        GetPlayerInfo(); // Get the Player's info
        playerControls = Player.Controls; // Access movement controls

        // ===== Target =====
        targetGO = GameObject.Find("Target"); // Assign GameObject
        targetInfo = targetGO.GetComponent<TargetInfo>(); // Access TargetInfo.cs
        GetTargetInfo(); // Get the Target's info
    }

    public void GetPlayerInfo()
    {
        // Get the following information about the Player
        playerRB = playerInfo.GetRigidbody2D(); // RigidBody2D
        startPos = playerInfo.GetPlayerPosition(); // Starting Position
        moveSpeed = playerInfo.GetPlayerSpeedX(); // Horizontal Speed
        floatSpeed = playerInfo.GetPlayerSpeedY(); // Vertical Speed

        // Debug this info
        Debug.Log($"PlayerMovement.cs > GetPlayerInfo(): Player's starting position is ({startPos.x}, {startPos.y})");
        Debug.Log($"PlayerMovement.cs > GetPlayerInfo(): Player's horizontal speed is {moveSpeed}");
        Debug.Log($"PlayerMovement.cs > GetPlayerInfo(): Player's vertical speed is {floatSpeed}");
    }

    public void GetTargetInfo()
    {
        // Get the following information about the Target
        targetPos = targetInfo.GetTargetPosition(); // Target's Position

        // Debug this info
        Debug.Log($"PlayerMovement.cs > GetTargetInfo(): Target's position is {targetPos}");
    }

    void Start()
    {
        // When the script is called, grab the player's starting
        // position and set it as the current position.
        playerPos = startPos;
        // The player's position will then
        // continuously be updated in Update()
    }

    private void OnEnable()
    {
        playerControls.Enable();
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