using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem.Android;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused;
    public GameObject playerObject;
    public Button resumeButton;
    public Button restartButton;
    public Button quitButton;
    public GameObject buttons;
    public GameObject images;
    private UnityEngine.Vector2 visibleMenuPosition;
    private bool canPause;
    void Awake()
    {
        canPause = true;
        buttons.SetActive(false);
        images.SetActive(false);
        pauseMenu.transform.position = playerObject.transform.position;
        resumeButton = GetComponent<Button>();
        restartButton = GetComponent<Button>();
        quitButton = GetComponent<Button>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) & canPause == true)
        {
            PauseGame();
        }
    }
    void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0;
        canPause = false;
        MoveMenuInView();
    }
    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        canPause = true;
        MoveMenuOutOfView();
    }
    void MoveMenuInView()
    {
        visibleMenuPosition = pauseMenu.transform.position;
        playerObject.transform.position = pauseMenu.transform.position;
        pauseMenu.SetActive(true);
        buttons.SetActive(true);
        images.SetActive(true);
    }
    void MoveMenuOutOfView()
    {   
        pauseMenu.SetActive(false);
        buttons.SetActive(false);
        images.SetActive(false);
    }
    public void RestartGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("AltLevel");
    }
    public void QuitGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}