using UnityEngine;

// This is the BackgroundInfo class. It encapsulates general data and info about
// the Background game object, which is utilized throughout other scripts.
//
// Note that the game art for the background is controlled through a canvas object,
// which is the actual item moving throughout the scene. This is to maintain an even
// aspect ratio.

public class BackgroundInfo : MonoBehaviour
{

    // ===== Variables =====
    private Camera eventCamera; // Event Camera attached to the Canvas
    private Vector2 canvasPosition; // Coordinates of the Canvas (X,Y)
    [SerializeField] private float parallaxOffset; // Parallax Offset of the Canvas

    // =====================
    
    // Get the Canvas' Event Camera
    public Camera GetEventCamera()
    {
        eventCamera = GetComponent<Canvas>().worldCamera;
        return eventCamera;
    }

    // Get the Canvas' location in the scene
    public Vector2 GetCanvasPosition()
    {
        // Get the Canvas' position from the Transform component
        canvasPosition = transform.position;
        return canvasPosition; // Return the position in a Vector2 for any time this method is called
    }

    // Get the Canvas' vertical movement speed
    public float GetParallaxOffset()
    {
        return parallaxOffset;
    }
}
