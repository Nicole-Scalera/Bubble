using UnityEngine;

public class PlayerInfo : MonoBehaviour
{

    // Variable to store the coordinates of the Player (X,Y,Z)
    private Vector2 playerPosition;

    void Awake()
    {
        
    }

    // Encapsulation of assigning the player position
    public Vector2 GetPlayerCoords()
    {
        // Get the player's position from the Transform component
        playerPosition = transform.position;
        Debug.Log("From the GetPlayerPosition() in the PlayerInfo class: (" + playerPosition.x + ", " + playerPosition.y + ")");
        return playerPosition; // Return the position in a Vector2 for any time this method is called
    }
    
}
