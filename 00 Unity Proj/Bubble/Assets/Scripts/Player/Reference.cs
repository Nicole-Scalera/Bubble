using UnityEngine;

public class Reference : MonoBehaviour
{

    private Vector2 startPos; // Player's Starting Location
    private Vector2 playerPos; // Player's Current Location
    private Vector2 targetPos; // Target's Location

    public TargetInfo targetScript; // TargetInfo.cs
    public PlayerInfo playerInfoScript; // PlayerInfo.cs

    private float floatSpeed = 5;

    private void Awake()
    {

        // ===== Player =====
        GameObject playerGO = GameObject.Find("Player"); // Assign GameObject
        playerInfoScript = playerGO.GetComponent<PlayerInfo>(); // Access PlayerInfo.cs
        startPos = playerInfoScript.GetPlayerCoords(); // Get the starting position of the Player
        Debug.Log("From Reference.cs | Player Coordinates Received: (" + startPos.x + ", " + startPos.y + ")");

        // ===== Target =====
        GameObject targetGO = GameObject.Find("Target"); // Assign GameObject
        targetScript = targetGO.GetComponent<TargetInfo>(); // Access TargetInfo.cs
        targetPos = targetScript.GetTargetPosition(); // Get the location of the target
        Debug.Log("From Reference.cs | Player Coordinates Received: (" + targetPos.x + ", " + targetPos.y + ")");

    }

    private void Start()
    {
        playerPos = startPos;
    }


    void Update()
    {

        float step = floatSpeed * Time.deltaTime;

        // Update the Player's current position
        playerPos = transform.position;

        // Move towards the target
        transform.position = Vector2.MoveTowards(playerPos, targetPos, step);
    }
}
