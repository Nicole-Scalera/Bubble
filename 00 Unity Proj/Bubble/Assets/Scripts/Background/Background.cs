using System;
using UnityEngine;
using UnityCommunity.UnitySingleton;

// This is the Background class. It encapsulates general data and info about
// the Background game object, which is utilized throughout other scripts.

public class Background : MonoBehaviour
{    
    // ===== Variables =====
    private string backgroundName; // Name of the GameObject
    private Rigidbody2D backgroundRB; // Background's Rigidbody Component
    private Vector2 startPos; // Background's Starting Position (X,Y)
    private Vector2 backgroundPosition; // Coordinates of the background (X,Y)
    [SerializeField] private float backgroundSpeed; // background's Vertical Speed (Automatic)
    [SerializeField] private float parallaxOffset; // Parallax Offset of the Canvas
    // =====================

    void Awake()
    {
        // Initialize Rigidbody2D
        backgroundRB = GetComponent<Rigidbody2D>();
    }
    
    void Start()
    {
        // Get the name of the GameObject
        backgroundName = gameObject.name;
    }
    
    // Get the background's name
    public String GetBackgroundName()
    {
        return backgroundName;
    }
    
    // Get the background's location in the scene
    public Vector2 GetBackgroundPosition()
    {
        backgroundPosition = transform.position;
        return backgroundPosition;
    }

    // Get the background's vertical movement speed
    public float GetBackgroundSpeed()
    {
        return backgroundSpeed;
    }

    // Get the Rigidbody2D component
    public Rigidbody2D GetRigidbody2D()
    {
        return backgroundRB;
    }

}
