using UnityEngine;

public class PlayerInfo : MonoBehaviour
{

    // Variable to store the coordinates of the Player (X,Y,Z)
    public Vector2 playerPosition;

    void Awake()
    {
        // Assign the coordinates to targetPosition
        playerPosition = GetComponent<Transform>().position;
        Debug.Log("From the TargetInfo class: " + playerPosition);
    }

    // Encapsulation of assigning the target position
    public Vector2 GetPlayerPosition()
    {
        return playerPosition;
    }

}
