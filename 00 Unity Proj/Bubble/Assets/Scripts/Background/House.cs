using System;
using UnityEngine;
using UnityCommunity.UnitySingleton;

public class House : PersistentMonoSingleton<House>
{
    
    
    // ===== Variables =====
    private Rigidbody2D houseRB; // House's Rigidbody Component
    private Vector2 startPos; // House's Starting Position (X,Y)
    private Vector2 housePosition; // Coordinates of the House (X,Y)
    [SerializeField] private float houseSpeed; // House's Vertical Speed (Automatic)
    // =====================

    void Awake()
    {
        // Initialize Rigidbody2D
        houseRB = GetComponent<Rigidbody2D>();
    }
    
    // Get the House's location in the scene
    public Vector2 GetHousePosition()
    {
        housePosition = transform.position;
        return housePosition;
    }

    // Get the House's vertical movement speed
    public float GetHouseSpeed()
    {
        return houseSpeed;
    }

    // Get the Rigidbody2D component
    public Rigidbody2D GetRigidbody2D()
    {
        return houseRB;
    }
    
}