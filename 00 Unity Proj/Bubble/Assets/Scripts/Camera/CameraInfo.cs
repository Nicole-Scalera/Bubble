// Note for Annadaliah:
// This class will be modified later on, so just leave it for now. I was just
// trying to grab the most basic info about the Main Camera in the scene. I using
// the "SerializeField" attribute to view the camera's position in the Inspector.
//
// In other words, when implementing collison detection through scripts, don't worry
// about it if the camera runs into any errors. It shouldn't, but in case there's any
// issues with it, leave it for now, we can create a new branch for that as needed.
// -- Nikki

using UnityEngine;

// This is the CameraInfo class. It encapsulates general data and info about
// the Main Camera game object, which is utilized throughout other scripts.

public class CameraInfo : MonoBehaviour
{

    // ===== Variables =====
    [SerializeField] private Vector2 cameraPosition; // Coordinates of the Camera (X,Y)
    // ^^^ Serializing to view
    // in the Inspector
    private Camera camComponent; // Camera component attached to the GameObject
    // =====================

    // Get the Camera component on the object
    public Camera GetCameraComponent()
    {
        camComponent = GetComponent<Camera>();
        return camComponent;
    }

    // Get the Camera's location in the scene
    public Vector2 GetCameraPosition()
    {
        // Get the Player's position from the Transform component
        cameraPosition = transform.position;
        return cameraPosition; // Return the position in a Vector2 for any time this method is called
    }

}
