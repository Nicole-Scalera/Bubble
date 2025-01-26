using UnityEngine;

// This is the PlayerInfo class. It encapsulates general data and info about
// the Player game object, which is utilized throughout other scripts.

public class PlayerInfo : MonoBehaviour
{

    // ===== Variables =====
    private Vector2 playerPosition; // Coordinates of the Player (X,Y)
    private float moveSpeed; // Player's Horizontal Speed (Player-controlled)
    private float floatSpeed; // Player's Vertical Speed (Automatic)
    private Rigidbody2D playerRB; // Player's Rigidbody Component

    // =====================

    void Awake()
    {
        
    }

    // Get the Player's location in the scene
    public Vector2 GetPlayerPosition()
    {
        // Get the Player's position from the Transform component
        playerPosition = transform.position;
        return playerPosition; // Return the position in a Vector2 for any time this method is called
    }

    // Get the Player's horizontal movement speed
    public float GetPlayerSpeedX()
    {
        moveSpeed = 10;
        return moveSpeed;
    }

    // Get the Player's vertical movement speed
    public float GetPlayerSpeedY()
    {
        floatSpeed = 1f;
        return floatSpeed;
    }

    // Get the Rigidbody2D component
    public Rigidbody2D GetRigidbody2D()
    {
        playerRB = GetComponent<Rigidbody2D>();
        return playerRB;
    }

}
