using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    // Speed at which the obstacle will move from one point to another
    [SerializeField] private float speed;
    
    // Tells the obstacle where the movement starts from
    public int startingPoint;
    
    // Tells the obstacle which positions or points that the obstacle will
    // travel between, if wanted could use this in the inspector within Unity
    // to vary the movement or direction that the obstacle takes
    public Transform[] points;
    
    // References the Rigidbody of the player to store for later
    Rigidbody2D playerRigidBody;
    
    // Helps to make the obstacle continuously move throughout the duration of the scene open
    private int i;
    private void Awake()
    {
        // Tbh I don't exactly remember why I used this for
        playerRigidBody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        
        // This is to make sure that the obstacle moves as soon as the game is launched
        transform.position = points[startingPoint].position;
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
