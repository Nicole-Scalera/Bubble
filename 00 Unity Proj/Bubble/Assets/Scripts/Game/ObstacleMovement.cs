using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed;
    public int startingPoint;
    public Transform[] points;
    Rigidbody2D playerRigidBody;
    public PlayerMovement myPlayer;
    private int i;
    void Start()
    {
        transform.position = points[startingPoint].position;
    }
    void Update()
    {
        if (UnityEngine.Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {
            i++;
            if (i == points.Length)
            {
                i = 0;
            }
        }
        transform.position = UnityEngine.Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }
}
