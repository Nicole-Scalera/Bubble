using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed;
    public int startingPoint;
    public Transform[] points;
    Rigidbody2D playerRigidBody;
    private int i;
    private void Awake()
    {
        playerRigidBody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
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
        }
        transform.position = UnityEngine.Vector2.MoveTowards(transform.position, points[i].position, speed* Time.deltaTime);
    }
}
