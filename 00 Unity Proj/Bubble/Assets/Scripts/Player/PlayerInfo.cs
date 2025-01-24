using UnityEngine;

public class PlayerInfo : MonoBehaviour
{

    // Variable to store the coordinates of the Player (X,Y,Z)
    private Vector2 playerPosition;

    void Awake()
    {
        // Assign the coordinates to playerPosition
        //Debug.Log("From the Awake() in the TargetInfo class: " + playerPosition);
    }

    // Encapsulation of assigning the player position
    public Vector2 GetPlayerPosition()
    {
        playerPosition = GetComponent<Transform>().position;
        Debug.Log("From the GetPlayerPosition() in the PlayerInfo class: (" + playerPosition.x + ", " + playerPosition.y + ")");
        return playerPosition;
    }

}
