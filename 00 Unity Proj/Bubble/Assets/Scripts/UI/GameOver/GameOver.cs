using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverMenu;
    public GameObject buttons;
    public GameObject images;
    public GameObject playerObject;
    private UnityEngine.Vector2 visibleMenuPosition;
    public Button retryButton;
    public Button quitButton;
    private int livesPlayerHas;
    void Awake()
    {
        buttons.SetActive(false);
        images.SetActive(false);
        gameOverMenu.transform.position = playerObject.transform.position;
    }
    public void Start()
    {
        retryButton = GetComponent<Button>();
        quitButton = GetComponent<Button>();
    }
    void Update()
    {
        livesPlayerHas = GameObject.Find("Player").GetComponent<PlayerRespawn>().playerLives;
        if (livesPlayerHas <= 0)
        {
            MoveMenuInView();
        }
    }
    void MoveMenuInView()
    {
        visibleMenuPosition = gameOverMenu.transform.position;
        playerObject.transform.position = gameOverMenu.transform.position;
        gameOverMenu.SetActive(true);
        buttons.SetActive(true);
        images.SetActive(true);
    }
    public void RetryGame()
    {
        SceneManager.LoadScene("Level2");
    }
    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
