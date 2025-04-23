using System;
using UnityEngine;
using UnityCommunity.UnitySingleton;

public class Obstacle : PersistentMonoSingleton<Obstacle>
{
    // ===== Variables =====
    private string obstacleName; // Name of the GameObject
    private Rigidbody2D obstaclesRB; // Obstacles' Rigidbody Component
    private Vector2 startPos; // Obstacles' Starting Position (X,Y)
    private Vector2 obstaclesPosition; // Coordinates of the Obstacles (X,Y)
    [SerializeField] private float obstacleSpeedX; // Obstacles' Horizontal Speed
    [SerializeField] private float obstacleSpeedY; // Obstacles' Vertical Speed
    // =====================

    void Awake()
    {
        // Initialize Rigidbody2D
        obstaclesRB = GetComponent<Rigidbody2D>();
    }
    
    void Start()
    {
        // Get the name of the GameObject
        obstacleName = gameObject.name;

        // Print the name to the console
        Debug.Log($"Obstacle Name: {obstacleName}");
    }
    
    // Get the Obstacles' name
    public String GetObstacleName()
    {
        return obstacleName;
    }
    
    // Get the Obstacles' location in the scene
    public Vector2 GetObstaclePosition()
    {
        obstaclesPosition = transform.position;
        return obstaclesPosition;
    }

    // Get the Obstacles' horizontal movement speed
    public float GetObstacleSpeedX()
    {
        return obstacleSpeedX;
    }
    
    // Get the Obstacles' vertical movement speed
    public float GetObstacleSpeedY()
    {
        return obstacleSpeedY;
    }

    // Get the Rigidbody2D component
    public Rigidbody2D GetRigidbody2D()
    {
        return obstaclesRB;
    }
    
}