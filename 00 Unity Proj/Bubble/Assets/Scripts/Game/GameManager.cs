// using Obvious.Soap.Example;
using UnityCommunity.UnitySingleton;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : PersistentMonoSingleton<GameManager>
{
    private Player player;
    private SceneChanger sceneChanger; // Player.cs
    public static PlayerControls playerControls;
    private string currentScene; // Current Scene Name

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
    
    private bool isPaused = false; // Boolean to check if game is paused


    private void Awake()
    {
        // ===== Player =====
        player = Player.Instance; // Access Player.cs

        // ===== Target =====
        targetObject = GameObject.Find("Target"); // Assign Target GameObject

        // ===== Main Camera =====
        cameraGO = GameObject.Find("Main Camera"); // Assign Main Camera
        mainCameraInfo = cameraGO.GetComponent<CameraInfo>(); // Access CameraInfo.cs
        GetCameraInfo();
        
        sceneChanger = SceneChanger.Instance;
        currentScene = SceneChanger.Instance.GetCurrentSceneName();
        
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
    
    public void RestartGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(currentScene);
    }

}
