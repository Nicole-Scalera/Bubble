using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject gameOverMenu = null;
    public GameObject playerObject;
    private UnityEngine.Vector2 visibleMenuPosition;
    public Button retryButton;
    public Button quitButton;
    // Start is called before the first frame update
    void Start()
    {
        retryButton = GetComponent<Button>();
        quitButton = GetComponent<Button>();
        MoveMenuInView();
    }
    void MoveMenuInView()
    {
        visibleMenuPosition = gameOverMenu.transform.position;
        playerObject.transform.position = gameOverMenu.transform.position;
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
