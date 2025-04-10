using System;
using UnityEngine;
using UnityCommunity.UnitySingleton;

// This is the PlayerInfo class. It encapsulates general data and info about
// the Player game object, which is utilized throughout other scripts.

public class Player : PersistentMonoSingleton<Player>
{
    
    // Singleton instance for global reference
    private static PlayerControls _controls;
    
    // Constructor that forces only a single
    // instance of PlayerControls to be created
    public static PlayerControls Controls
    {
        get
        {
            // If Controls are null, create a new instance
            if (_controls == null)
            {
                _controls = new PlayerControls(); // Access movement controls
            }

            // Return the PlayerControls instance
            return _controls;
        }
    }
    
    // ===== Variables =====
    private Rigidbody2D playerRB; // Player's Rigidbody Component
    private Vector2 playerPosition; // Coordinates of the Player (X,Y)
    [SerializeField] public float moveSpeed; // Player's Horizontal Speed (Player-controlled)
    [SerializeField] private float floatSpeed; // Player's Vertical Speed (Automatic)
    // =====================

    void Awake()
    {
        // Initialize Rigidbody2D
        playerRB = GetComponent<Rigidbody2D>();
    }
    
    // Get the Player's location in the scene
    public Vector2 GetPlayerPosition()
    {
        playerPosition = transform.position;
        return playerPosition;
    }

    // Get the Player's horizontal movement speed
    public float GetPlayerSpeedX()
    {
        return moveSpeed;
    }

    // Get the Player's vertical movement speed
    public float GetPlayerSpeedY()
    {
        return floatSpeed;
    }

    // Get the Rigidbody2D component
    public Rigidbody2D GetRigidbody2D()
    {
        return playerRB;
    }
    
}