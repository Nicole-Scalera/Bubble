using System;
using UnityEngine;

// This class defines the overall process of props moving towards
// a target object in the scene. It is inherited by other classes
// that implement the class and the IMovable interface.

public abstract class MovableProp : MonoBehaviour, IMovable
{
    protected Target target; // Target.cs
    protected Rigidbody2D rb; // Rigidbody2D
    protected Vector2 startPos; // Starting position (set once)
    protected Vector2 currentPos; // Current position (set continuously)
    protected Vector2 newPos; //  New position (set continuously)
    protected Vector2 targetPos; //  Target position
    protected float speed; // Speed
    
    protected virtual void Awake()
    {
        // ===== Target =====
        target = Target.Instance; // Access Target.cs
    }

    protected virtual void Start()
    {
        GetPropInfo(); // Get the prop's info (overriden by child class)
        GetTargetInfo(); // Get the target's info

        // Initialize the current position
        currentPos = startPos;
    }

    // Method to get prop-specific information (to be overridden by child classes)
    public virtual void GetPropInfo()
    {
        rb = GetComponent<Rigidbody2D>(); // RigidBody2D
        startPos = transform.position; // Starting Position
        speed = 5f; // Default Speed

        // Debug this info
        Debug.Log($"MovableProp.cs > GetPropInfo(): Prop's starting position is ({startPos.x}, {startPos.y})");
        Debug.Log($"MovableProp.cs > GetPropInfo(): Prop's movement speed is {speed}");
    }
    
    // Grab info about Target
    public virtual void GetTargetInfo()
    {
        // Get the following information about the Target
        targetPos = target.GetTargetPosition(); // Target's Position
        
        // Debug this info
        Debug.Log($"Target's position is {targetPos}");
    }

    public void Update()
    {
        UpdatePosition();
    }
    
    public void FixedUpdate()
    {
        Move();
    }

    // Update the prop's position continuously
    public virtual void UpdatePosition()
    {
        // Prop Speed (Vertical)
        float step = speed * Time.deltaTime;
        
        // Update the Y coordinate | Move prop towards target at constant speed
        float newY = Vector2.MoveTowards(new Vector2(0, currentPos.y), new Vector2(0, targetPos.y), step).y;
        
        // Set the prop's position to the new coordinates
        newPos = new Vector2(currentPos.x, newY);
        currentPos = newPos;
    }

    // Move the prop (call this in FixedUpdate())
    public virtual void Move()
    {
        // rb.MovePosition(currentPos);
        
        // Calculates the props's destination to move its Rigidbody
        // at a constant speed with no acceleration
        Vector2 destination = new Vector2(rb.position.x + currentPos.x * speed * Time.fixedDeltaTime, currentPos.y);
        rb.MovePosition(destination);
    }
}

// Interface explains how this data is supposed to be implemented.
// i.e., it creates a blueprint for gathering the data.
public interface IMovable
{
    void GetPropInfo();
    void GetTargetInfo();
    void UpdatePosition();
    void Move();
}