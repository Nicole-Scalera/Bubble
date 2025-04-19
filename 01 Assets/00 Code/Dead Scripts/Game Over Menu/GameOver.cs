using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class GameOver : MonoBehaviour
{
    private string currentScene;
    
    // List to hold UI contents
    [SerializeField] private List<GameObject> contents;
    
    // UI GameObjects
    [SerializeField] private GameObject gameOverMenu; // The Game Over Menu GameObject

    [SerializeField] private GameObject goSign; // Pop-up sign
    [SerializeField] private GameObject goRetryButton; // Retry button
    [SerializeField] private GameObject goQuitButton; // Quit button
    [SerializeField] private GameObject goBackground; // Background

    private PlayerControls playerControls; // PlayerControls.cs

    // ===== Variables/Components =====
    // Create References to relevant GameObjects
    public GameObject playerObject;
    private int livesPlayerHas;
    // ================================

    void Awake()
    {
        // Get the current scene for Restart()
        currentScene = SceneChanger.Instance.GetCurrentSceneName();

        // Find UI elements
        gameOverMenu = GameObject.Find("GameOverMenu");
        goSign = GameObject.Find("goSign");
        goRetryButton = GameObject.Find("goRetryButton");
        goQuitButton = GameObject.Find("goQuitButton");
        goBackground = GameObject.Find("GameOverBackground");

        //Create a list to store buttons
        contents = new List<GameObject>
        {
            gameOverMenu,
            goSign,
            goRetryButton,
            goQuitButton,
            goBackground
        };
        
        // Hide UI elements
        ToggleMenu(false);


    }
    public void Start()
    {
        playerObject = GameObject.Find("Player");
    }
    void Update()
    {
        // livesPlayerHas = playerObject.GetComponent<PlayerRespawn>().playerLives;
        //
        // if (livesPlayerHas <= 0)
        // {
        //     // Activate the Game Over Menu
        //     gameOverMenu.SetActive(true);
        // }
        // else
        // {
        //     // Deactivate the Game Over Menu if player has lives
        //     gameOverMenu.SetActive(false);
        // }
    }

    // Toggle Menu
    private void ToggleMenu(bool isActive)
    {
        foreach (GameObject item in contents)
        {
            item.SetActive(isActive);
        }
    }

    // Retry the game and reload the current level
    public void RetryGame()
    {
        SceneManager.LoadScene(currentScene);
    }
    
    // Quit the game and return to the Main Menu
    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

}