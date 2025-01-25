using System;
using UnityEngine;

public class BubbleFloat : MonoBehaviour
{

    // ===== Script References =====
    // Create a reference to the following scripts:
    public TargetInfo targetScript; // TargetInfo.cs
    public PlayerInfo playerInfoScript; // PlayerInfo.cs
    // =============================

    // ===== Variables/Components =====
    private Vector2 startPos; // Player's Starting Location
    private Vector2 playerPos; // Player's Current Location
    private Vector2 targetPos; // Target's Location
    private float floatSpeed = 5; // Player's Movement Speed (Vertical)

    // ================================

    private void Awake()
    {

        // ===== Player =====
        GameObject playerGO = GameObject.Find("Player"); // Assign GameObject
        playerInfoScript = playerGO.GetComponent<PlayerInfo>(); // Access PlayerInfo.cs
        GetPlayerStartPosition(); // Get coordinates (X,Y,Z)

        // ===== Target =====
        GameObject targetGO = GameObject.Find("Target"); // Assign GameObject
        targetScript = targetGO.GetComponent<TargetInfo>(); // Access TargetInfo.cs
        GetTargetCoords(); // Get coordinates (X,Y,Z)
    
    }

    public void GetPlayerStartPosition()
    {
        startPos = playerInfoScript.GetPlayerCoords(); // Get the starting position of the Player
        Debug.Log("From MoveExample.cs | Player Coordinates Received: (" + startPos.x + ", " + startPos.y + ")");
    }

    public void GetTargetCoords()
    {
        targetPos = targetScript.GetTargetPosition(); // Get the location of the target
        Debug.Log("From MoveExample.cs | Target Coordinates Received: (" + targetPos.x + ", " + targetPos.y + ")");
    }

    void Start()
    {
        // When the script is called, grab the player's starting
        // position and set it as the current position.
        playerPos = startPos;
        // The player's position will then continuously be updated in Update()
    }

    void Update()
    {
        // How fast is the player getting there?
        float step = floatSpeed * Time.deltaTime;

        // Continuously update the Player's current position
        playerPos = transform.position;

        // Move the Player towards the Target
        transform.position = Vector2.MoveTowards(playerPos, targetPos, step);
    }
    
}