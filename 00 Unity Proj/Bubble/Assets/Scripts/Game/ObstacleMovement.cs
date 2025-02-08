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
    UnityEngine.Vector3 moveDirection;
    private void Awake()
    {
        playerRigidBody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        DirectionCalculate();
    }
    void Update()
    {
        if (UnityEngine.Vector2.Distance(transform.position, points[i].position) < 0.05f)
        {
            i++;
            if (i == points.Length)
            {
                i = 0;
                DirectionCalculate();
            }
        }
        if (UnityEngine.Vector2.Distance(transform.position,points[i].position) > 0.02f)
        {
            UnityEngine.Vector2.MoveTowards(transform.position,points[i].position, speed * Time.deltaTime);
            DirectionCalculate();
        }
    }
    void DirectionCalculate() 
    {
        moveDirection = transform.position.normalized;
    }
}
