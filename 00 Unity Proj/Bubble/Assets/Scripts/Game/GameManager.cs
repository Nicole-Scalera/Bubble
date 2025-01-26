using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Create an instance of the GameManager so
    // that we can easily access it anywhere
    public static GameManager Instance;

    // Create References to relevant GameObjects
    public GameObject playerObject; // Player
    public GameObject targetObject; // Target

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

        targetObject = GameObject.Find("Target"); // Assign Target GameObject
        playerObject = GameObject.Find("Player"); // Assign Player GameObject

    }

    // Start is called before the first frame update
    void Start()
    {

    }
    
}
