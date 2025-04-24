using UnityEngine;

// This class defines the movement of the background in the game.
// It inherits from the MovableProp class and implements the
// IMovable interface (also in MovableProp.cs).

public class BackgroundMovement : MovableProp
{
    // ===== Script References =====
    private Background background; // House.cs
    // =============================

    // Override Awake() in MovableProp.cs
    protected override void Awake()
    {
        // ===== Target =====
        base.Awake(); // Target initialized in base class

        // ===== House =====
        background = GetComponent<Background>(); // Access Background.cs
    }

    // Get the following information about the House
    public override void GetPropInfo()
    {
        propName = background.GetBackgroundName(); // House Name
        rb = background.GetRigidbody2D(); // RigidBody2D
        startPos = background.GetBackgroundPosition(); // Starting Position
        speedY = background.GetBackgroundSpeed(); // Horizontal Speed

        // Debug info about prop (called from MovableProp.cs)
        DebugPropInfo();
    }
}