using UnityEngine;

public class TargetInfo : MonoBehaviour
{

    // Variable to store the coordinates of the target (X,Y,Z)
    public Vector2 targetPosition;

    void Awake()
    {
        // Assign the coordinates to targetPosition
        targetPosition = GetComponent<Transform>().position;
        Debug.Log("From the TargetInfo class: " + targetPosition);
    }

    // Encapsulation of assigning the target position
    public Vector2 GetTargetPosition()
    {
        // Get the player's position from the Transform component
        targetPosition = transform.position;
        Debug.Log("From the GetTargetPosition() in the TargetInfo class: (" + targetPosition.x + ", " + targetPosition.y + ")");
        return targetPosition; // Return the position in a Vector2 for any time this method is called
    }

}
