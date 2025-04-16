using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class PauseMenu : MonoBehaviour, PlayerControls.IGameControlsActions
{
    private string currentScene;
    
    // Booleans
    private bool canPause = true; // Boolean to check if game can be paused
    private bool isPaused = false; // Boolean to check if game is paused

    // List to hold UI contents
    [SerializeField] private List<GameObject> contents;
    
    // UI GameObjects
    [SerializeField] private GameObject pauseMenu; // The Pause Menu GameObject
    [SerializeField] private GameObject resumeButton; // Resume button
    [SerializeField] private GameObject pauseRetryButton; // Retry button
    [SerializeField] private GameObject pauseQuitButton; // Quit button
    [SerializeField] private GameObject pauseBackground;

    private PlayerControls playerControls; // PlayerControls.cs
    
    void Awake()
    {
        // Get the current scene for Restart()
        currentScene = SceneChanger.Instance.GetCurrentSceneName();
        
        // Initialize PlayerControls
        playerControls = new PlayerControls();
        playerControls.GameControls.SetCallbacks(this); // Set this class as listener
        playerControls.GameControls.Enable();

        // Find UI elements
        pauseMenu = GameObject.Find("PauseMenu");
        pauseBackground = GameObject.Find("PauseBackground");
        resumeButton = GameObject.Find("ResumeButton");
        pauseRetryButton = GameObject.Find("pauseRetryButton");
        pauseQuitButton = GameObject.Find("pauseQuitButton");

        //Create a list to store buttons
        contents = new List<GameObject>
        {
            pauseMenu,
            pauseBackground,
            resumeButton,
            pauseQuitButton,
            pauseRetryButton
        };
        
        // Hide UI elements
        ToggleMenu(false);
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }
    
    // Toggle Menu
    private void ToggleMenu(bool isActive)
    {
        foreach (GameObject item in contents)
        {
            item.SetActive(isActive);
        }
    }

    // Using Input System (PlayerControls.cs) to pause the game
    public void OnPause(InputAction.CallbackContext context)
    {
        // If NOT paused and the Escape is triggered
        if (context.started && canPause)
        {
            PauseGame(); // Pause the game
        }

        // If paused and the Escape is triggered
        else if (context.started && isPaused)
        {
            ResumeGame(); // Resume the game
        }
    }

    void PauseGame()
    {
        Debug.Log("Game is paused");

        isPaused = true;
        Time.timeScale = 0;
        canPause = false;

        // Hide UI elements
        ToggleMenu(true);
    }

    // Call to Resume the game
    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        canPause = true;

        // Hide UI elements
        ToggleMenu(false);
    }

    // Call to Restart the game
    public void RestartGame()
    {
        GameManager.Instance.RestartGame();
    }

    // Call to Quit the game
    public void QuitGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    
    void OnDestroy()
    {
        playerControls.GameControls.Disable();
    }
}
