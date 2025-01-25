using UnityEngine;

// 2D MoveTowards example
// Move the sprite to where the mouse is clicked
//
// Set speed to -1.0f and the sprite will move
// away from the mouse click position forever

public class BubbleFloat : MonoBehaviour
{

    // ===== Script References =====
    // Create a reference to the following scripts:
    public TargetInfo targetScript; // TargetInfo.cs
    //public PlayerMovement playerMovementScript; // PlayerMovement.cs
    public PlayerInfo playerInfoScript; // PlayerInfo.cs
    // =============================

    // ===== Variables/Components =====
    private Rigidbody2D playerRB; // Player's Rigidbody Component
    //private Vector2 playerPos; // Player's Location
    private Vector2 targetPos; // Target's Location

    // ================================
    
    // === Scrolling ===
    public float scrollSpeed;
    public float tileSizeZ;
    private Vector2 startPosition; // Where does the player start


    // How fast the bubble will approach the target
    //[SerializeField] private float floatSpeed = 10f;

    private float floatSpeed = 5;

    private void Awake()
    {

        // ===== Player =====
        GameObject playerGO = GameObject.Find("Player"); // Assign GameObject
        playerInfoScript = playerGO.GetComponent<PlayerInfo>(); // Access PlayerInfo.cs
        //playerMovementScript = playerGO.GetComponent<PlayerMovement>(); // Access PlayerInfo.cs
        GetPlayerStartPosition(); // Get coordinates (X,Y,Z)

        // ===== Target =====
        GameObject targetGO = GameObject.Find("Target"); // Assign GameObject
        targetScript = targetGO.GetComponent<TargetInfo>(); // Access TargetInfo.cs
        GetTargetCoords(); // Get coordinates (X,Y,Z)
    
    }

    public void GetPlayerStartPosition()
    {
        startPosition = playerInfoScript.GetPlayerCoords();
        Debug.Log("From MoveExample.cs | Player Coordinates Received: (" + startPosition.x + ", " + startPosition.y + ")");
    }

    public void GetTargetCoords()
    {
        targetPos = targetScript.GetTargetPosition();
        Debug.Log("From MoveExample.cs | Target Coordinates Received: (" + targetPos.x + ", " + targetPos.y + ")");
    }

    void Start()
    {

    }

    void Update()
    {

        float step = floatSpeed * Time.deltaTime;

        // move sprite towards the target location
        // transform.position = Vector2.MoveTowards(transform.position, target, step);

        //transform.position = new Vector2(transform.position.x, transform.position.y);
        //transform.position = new Vector2(transform.position.x, transform.position.y);
        
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        // transform.position = startPosition + Vector3.forward * newPosition;
        
        
    }

    private void PlayerInput()
    {
        // // Access buttons from PlayerControls.inputactions
        // movement = playerControls.MoveHorizontal.Move.ReadValue<Vector2>();
        // // This is continuously called in Update()
        // // to read the value of the X-axis.

    }
    
}