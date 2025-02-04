using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Create an instance of the GameManager so
    // that we can easily access it anywhere
    public static GameManager Instance;

    // Create References to relevant GameObjects
    public GameObject playerObject; // Player
    public GameObject targetObject; // Target
    public GameObject mainCamera; // Main Camera
    private Vector2 mainCameraPos; // Camera's Current Location
    private CameraInfo cameraInfo; // CameraInfo.cs

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
        playerObject = GameObject.Find("Player"); // Assign Player GameObject
        //playerInfo = playerGO.GetComponent<PlayerInfo>(); // Access PlayerInfo.cs

        // ===== Target =====
        targetObject = GameObject.Find("Target"); // Assign Target GameObject


        // ===== Main Camera =====
        mainCamera = GameObject.Find("Main Camera"); // Assign Main Camera
        cameraInfo = mainCamera.GetComponent<CameraInfo>(); // Access CameraInfo.cs
        GetCameraInfo();
    }

    // Get and assign camera information
    public void GetCameraInfo()
    {
        // Get the following information about the Camera
        mainCameraPos = cameraInfo.GetCameraPosition(); // Camera's Position
    }

    void Update() {
        // For Debugging:
        GetCameraInfo();
        Debug.Log($"GameManager.cs > Update(): Camera's position is ({mainCameraPos.x}, {mainCameraPos.y})");
    }
    
}
