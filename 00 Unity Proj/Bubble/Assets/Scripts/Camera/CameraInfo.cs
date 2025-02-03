using UnityEngine;

// This is the CameraInfo class. It encapsulates general data and info about
// the Main Camera game object, which is utilized throughout other scripts.

public class CameraInfo : MonoBehaviour
{

    // ===== Variables =====
    [SerializeField] private Vector2 cameraPosition; // Coordinates of the Camera (X,Y)
    // ^^^ Serializing to view
    // in the Inspector
    // =====================

    // Get the Camera's location in the scene
    public Vector2 GetCameraPosition()
    {
        // Get the Player's position from the Transform component
        cameraPosition = transform.position;
        return cameraPosition; // Return the position in a Vector2 for any time this method is called
    }

}
