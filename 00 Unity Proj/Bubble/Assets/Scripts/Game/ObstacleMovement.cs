using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D obstacleRB;

    private void Awake()
    {
        obstacleRB = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        // Move the Rigidbody to the next point
        obstacleRB.velocity = new Vector2 (speed, 0f);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Barrier"))
        {
            // Reverse the movement speed in
            // the opposite direction
            speed = -speed;
        }
    }
    
}
