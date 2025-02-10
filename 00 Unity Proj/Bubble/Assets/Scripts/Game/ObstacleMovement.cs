using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed; // Speed at which the obstacle will move from one point to another
    public int startingPoint; // Tells the obstacle where the movement starts from
    public Transform[] points; // Tells the obstacle which positions or points that the obstacle will travel between, if wanted could use this in the inspector within Unity to vary the movement or direction that the obstacle takes
    Rigidbody2D playerRigidBody; // References the Rigidbody of the player to store for later
    private int i; // Helps to make the obstacle continuously move throughout the duration of the scene open
    private void Awake()
    {
        playerRigidBody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>(); // Tbh I don't exactly remember why I used this for
        transform.position = points[startingPoint].position; // This is to make sure that the obstacle moves as soon as the game is launched
    }
    void Update()
    {
        if (UnityEngine.Vector2.Distance(transform.position, points[i].position) < 0.05f)
        {
            i++;
            if (i == points.Length)
            {
                i = 0;
            }
        } // All of this forces the obstacles to move
        transform.position = UnityEngine.Vector2.MoveTowards(transform.position, points[i].position, speed* Time.deltaTime); // Makes it this movement continue
    }
}
