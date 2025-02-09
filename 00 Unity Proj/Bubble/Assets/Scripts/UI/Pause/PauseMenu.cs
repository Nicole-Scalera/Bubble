using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu = null;
    public bool isPaused;
    public GameObject playerObject;
    private UnityEngine.Vector2 hiddenMenuPosition;
    private UnityEngine.Vector2 visibleMenuPosition;
    public GameObject menuStartPosition;
    public Button resumeButton;
    public Button restartButton;
    public Button quitButton;
    void Start()
    {
        resumeButton = GetComponent<Button>();
        restartButton = GetComponent<Button>();
        quitButton = GetComponent<Button>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }
    void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0;
        pauseMenu.SetActive(isPaused);
        MoveMenuInView();
    }
    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(isPaused);
        MoveMenuOutOfView();
    }
    void MoveMenuInView()
    {
        visibleMenuPosition = pauseMenu.transform.position;
        playerObject.transform.position = pauseMenu.transform.position;   
    }
    void MoveMenuOutOfView()
    {
        hiddenMenuPosition = menuStartPosition.transform.position;
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