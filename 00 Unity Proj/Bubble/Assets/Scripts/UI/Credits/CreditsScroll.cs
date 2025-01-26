using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsScroll : MonoBehaviour
{

    // ===== Variables/Components =====
    //private Rigidbody2D playerRB; // Player's Rigidbody Component
    private Vector3 creditsStart;
    private Vector2 creditsEnd = new Vector2((float)3.81469999e-06, (float)724.98999);
    private Vector2 creditsPos; // Current location of credits on screen
    private float scrollSpeed = 3;
    // ================================

    void Start()
    {
        // creditsStart = (-1.90729997e-06, -724.98999, 0);
        // When the script is called, grab the credits' starting
        // position and set it as the current position.
        creditsPos = creditsStart;
    }

    void Update()
    {
        // Scroll speed
        float step = scrollSpeed * Time.deltaTime;

        // Update the Player's current position
        creditsPos = transform.position;

        // Move towards the target
        transform.position = Vector2.MoveTowards(creditsStart, creditsEnd, step);
    }
}