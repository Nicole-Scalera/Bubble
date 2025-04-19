// using Obvious.Soap.Example;
using UnityCommunity.UnitySingleton;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : PersistentMonoSingleton<GameManager>
{
    private Player player; // Player.cs
    private SceneChanger sceneChanger; // SceneChanger.cs
    public static PlayerControls playerControls; // PlayerControls.cs
    private string currentScene; // Current Scene Name

    // ===== Script References =====
    public CameraInfo mainCameraInfo; // CameraInfo.cs
    // =============================

    // ===== Variables/Components =====
    // Create References to relevant GameObjects
    private GameObject playerObject; // Player
    private GameObject cameraGO; // Camera GameObject
    private Camera mainCamera; // Actual Main Camera
    private Vector2 mainCameraPos; // Camera's Current Location
    // ================================
    
    private bool isPaused = false; // Boolean to check if game is paused


    private void Awake()
    {
        // ===== References =====
        player = Player.Instance; // Access Player.cs
        sceneChanger = SceneChanger.Instance; // Access SceneChanger.cs

        // ===== Main Camera =====
        cameraGO = GameObject.Find("Main Camera"); // Assign Main Camera
        mainCameraInfo = cameraGO.GetComponent<CameraInfo>(); // Access CameraInfo.cs
        GetCameraInfo();
        
        // Get the name of the current scene
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

    // Update the current scene name everytime a new scene is loaded
    public void UpdateCurrentScene(string sceneName)
    {
        currentScene = sceneName;
        Debug.Log($"GameManager: Current scene is: " + currentScene);
    }

}
