using UnityEngine;

public class TargetInfo : MonoBehaviour
{

    // Variable to store the coordinates of the target (X,Y,Z)
    private Vector2 targetPosition;

    void Awake()
    {
        
    }

    // Get the Target's location in the scene
    public Vector2 GetTargetPosition()
    {
        // Get the Target's position from the Transform component
        targetPosition = transform.position;
        return targetPosition; // Return the position in a Vector2 for any time this method is called
    }

}
