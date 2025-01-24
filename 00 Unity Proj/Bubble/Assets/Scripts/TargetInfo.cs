using UnityEngine;

public class TargetInfo : MonoBehaviour
{

    // Variable to store the coordinates of the target (X,Y,Z)
    private Vector2 targetPosition;

    void Awake()
    {
        // Assign the coordinates to targetPosition
        //Debug.Log("From the Awake() in the TargetInfo class: " + targetPosition);
    }

    // Encapsulation of assigning the target position
    public Vector2 GetTargetPosition()
    {
        targetPosition = GetComponent<Transform>().position;
        Debug.Log("From the GetTargetPosition() in the TargetInfo class: (" + targetPosition.x + ", " + targetPosition.y + ")");
        return targetPosition;
    }

}
