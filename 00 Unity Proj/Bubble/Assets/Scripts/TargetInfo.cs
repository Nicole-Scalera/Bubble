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
        return targetPosition;
    }

}
