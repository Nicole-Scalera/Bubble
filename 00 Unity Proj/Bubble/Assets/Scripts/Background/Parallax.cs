using System;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    // ===== Script References =====
    public BackgroundInfo backgroundInfo; // BackgroundInfo.cs
    // =============================

    // ===== Variables/Components =====
    private Camera cam; // Event Camera
    private Vector2 startPos; // Canvas' Starting Location
    private float parallaxOffset; // Parallax Offset of the Canvas
    private GameObject backgroundGO;

    // Create Travel Property
    private Vector2 Travel => new Vector2(cam.transform.position.x, cam.transform.position.y) - startPos;
    // ================================
    
    private void Awake()
    {
        // ===== Canvas =====
        backgroundGO = GameObject.Find("Background Canvas"); // Assign GameObject
        backgroundInfo = backgroundGO.GetComponent<BackgroundInfo>(); // Access BackgroundInfo.cs
        GetCanvasInfo(); // Get the Canvas' info
    }

    public void GetCanvasInfo()
    {
        // Get the following information about the Background Canvas
        cam = backgroundInfo.GetEventCamera(); // Event Camera
        startPos = backgroundInfo.GetCanvasPosition(); // Starting Position
        parallaxOffset = backgroundInfo.GetParallaxOffset(); // Parallax Offset

        // Debug this info
        Debug.Log($"Parallax.cs > GetBackgroundInfo(): Event Camera for Background Canvas is {cam.name}");
        Debug.Log($"Parallax.cs > GetBackgroundInfo(): Canvas' starting position is ({startPos.x}, {startPos.y})");
        Debug.Log($"Parallax.cs > GetBackgroundInfo(): Canvas' parallax offset is {parallaxOffset}");
    }

    void Start()
    {
        // When the script is called, grab the Canvas' starting
        // position and set it as the current position.
        transform.position = startPos;
        // The Canvas' position will then
        // continuously be updated in Update()
    }

    private void FixedUpdate()
    {
        // Move the current game object's position
        transform.position = startPos + Travel * parallaxOffset;
    }
}