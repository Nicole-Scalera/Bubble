// using Obvious.Soap.Example;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Create an instance of the GameManager so
    // that we can easily access it anywhere
    public static GameManager Instance;
    
    public static PlayerControls playerControls;

    // ===== Script References =====
    public CameraInfo mainCameraInfo; // CameraInfo.cs
    // =============================

    // ===== Variables/Components =====
    // Create References to relevant GameObjects
    private GameObject playerObject; // Player
    private GameObject targetObject; // Target
    private GameObject cameraGO; // Camera GameObject
    private Camera mainCamera; // Actual Main Camera
    private Vector2 mainCameraPos; // Camera's Current Location
    // ================================


    private void Awake()
    {
        // Ensure only one instance of GameManager exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            Destroy(gameObject);
        }

        // ===== Player =====
        Player player = Player.Instance; // Access Player.cs

        // ===== Target =====
        targetObject = GameObject.Find("Target"); // Assign Target GameObject

        // ===== Main Camera =====
        cameraGO = GameObject.Find("Main Camera"); // Assign Main Camera
        mainCameraInfo = cameraGO.GetComponent<CameraInfo>(); // Access CameraInfo.cs
        GetCameraInfo();
    }

    // Get and assign camera information
    public void GetCameraInfo()
    {
        // Get the following information about the Camera
        mainCamera = mainCameraInfo.GetCameraComponent(); // Camera Component
        mainCameraPos = mainCameraInfo.GetCameraPosition(); // Camera's Position
    }

    void Update()
    {
        // For Debugging:
        GetCameraInfo();
        //Debug.Log($"GameManager.cs > Update(): Camera's position is ({mainCameraPos.x}, {mainCameraPos.y})");
    }

}
