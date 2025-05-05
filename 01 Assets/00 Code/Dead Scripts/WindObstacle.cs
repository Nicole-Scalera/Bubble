using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindObstacle : MonoBehaviour
{
    private PlayerInfo myPlayerMovement;
    public Collider2D windSpace;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            myPlayerMovement.moveSpeed = 1;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            myPlayerMovement.moveSpeed = 3;
        }
    }
}
