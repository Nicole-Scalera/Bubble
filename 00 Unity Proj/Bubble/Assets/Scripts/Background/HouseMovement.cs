using UnityEngine;

// This class defines the movement of the house in the game.
// It inherits from the MovableProp class and implements the
// IMovable interface (also in MovableProp.cs).

public class HouseMovement : MovableProp
{
    // ===== Script References =====
    private House house; // House.cs
    // =============================

    // Override Awake() in MovableProp.cs
    protected override void Awake()
    {
        // ===== Target =====
        base.Awake(); // Target initialized in base class

        // ===== House =====
        house = House.Instance; // Access House.cs
    }
    
    // Get the following information about the House
    public override void GetPropInfo()
    {
        propName = house.GetHouseName(); // House Name
        rb = house.GetRigidbody2D(); // RigidBody2D
        startPos = house.GetHousePosition(); // Starting Position
        speedY = house.GetHouseSpeed(); // Horizontal Speed

        // Debug info about prop (called from MovableProp.cs)
        DebugPropInfo();
    }
}