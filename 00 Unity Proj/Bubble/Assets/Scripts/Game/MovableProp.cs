using System;
using Unity.VisualScripting;
using UnityEngine;

// This class defines the overall process of props moving towards
// a target object in the scene. It is inherited by other classes
// that implement the class and the IMovable interface.

public abstract class MovableProp : MonoBehaviour, IMovable
{
    protected string propName; // Name of the GameObject
    protected Target target; // Target.cs
    protected Rigidbody2D rb; // Rigidbody2D
    protected Vector2 startPos; // Starting position (set once)
    protected Vector2 currentPos; // Current position (set continuously)
    protected Vector2 newPos; //  New position (set continuously)
    protected Vector2 targetPos; //  Target position
    protected float speedX; // Speed
    protected float speedY; // Speed
    
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

    // Method to get prop-specific information (overridden by child classes)
    public virtual void GetPropInfo()
    {
        propName = "empty prop name"; // Prop Name
        rb = GetComponent<Rigidbody2D>(); // RigidBody2D
        startPos = transform.position; // Starting Position
        speedY = 5f; // Default Y Speed
    }
    
    public virtual void DebugPropInfo()
    {
        // Debug this info (called by child classes)
        Debug.Log($"MovableProp.cs > GetPropInfo(): {propName}'s starting position is ({startPos.x}, {startPos.y})");
        Debug.Log($"MovableProp.cs > GetPropInfo(): {propName}'s horizontal speed is {speedX}");
        Debug.Log($"MovableProp.cs > GetPropInfo(): {propName}'s vertical speed is {speedY}");
    }
    
    // Get the following information about the Target
    public virtual void GetTargetInfo()
    {
        // Target's Position
        targetPos = target.GetTargetPosition();
        
        // Debug this info
        Debug.Log($"Target's position is {targetPos}");
    }

    public virtual void Update()
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
        float step = speedY * Time.deltaTime;
        
        // Update the Y coordinate | Move prop towards target at constant speed
        float newY = Vector2.MoveTowards(new Vector2(0, currentPos.y), new Vector2(0, targetPos.y), step).y;
        
        // Set the prop's position to the new coordinates
        newPos = new Vector2(currentPos.x, newY);
        currentPos = newPos;
    }

    // Move the prop (call this in FixedUpdate())
    public virtual void Move()
    {
        // Calculates the prop's destination to move its Rigidbody
        // at a constant speed with no acceleration
        Vector2 destination = new Vector2(rb.position.x + currentPos.x * speedX * Time.fixedDeltaTime, currentPos.y);
        rb.MovePosition(destination);
    }
    
    // Destroy when reaching the Target Object
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Target"))
        {
            Destroy(gameObject);
        }
    }
    
    // public virtual void ReachedTarget()
    // {
    //
    // }


}

// Interface explains how this data is supposed to be implemented.
// i.e., it creates a blueprint for gathering the data.
public interface IMovable
{
    void GetPropInfo();
    void DebugPropInfo();
    void GetTargetInfo();
    void UpdatePosition();
    void Move();
    // void ReachedTarget();
}