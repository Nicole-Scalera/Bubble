using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // ===== Script References =====
    private PlayerInfo playerScript; // PlayerInfo.cs
    private PlayerControls playerControls; // PlayerControls.cs
    // =============================

    // ===== Variables/Components =====
    private Rigidbody2D playerRB; // Player's Rigidbody Component
    private Vector2 playerPosition;

    // ================================

    [SerializeField] private float moveSpeed = 10f;

    private void Awake()
    {

        // Assign the Target GameObject
        GameObject playerGO = GameObject.Find("Player");

        // Access Input info for Player
        playerControls = new PlayerControls();

        // Access the PlayerInfo.cs script
        playerScript = playerGO.GetComponent<PlayerInfo>();

        // Grab the Rigidbody2D component
        playerRB = GetComponent<Rigidbody2D>();

        // Grab the player's coordinates (X,Y,Z) from PlayerInfo.cs
        playerPosition = GetComponent<Transform>().position;
        
    }

    private void Start()
    {

    }


    // Set controls to active ("Enable")
    private void OnEnable()
    {
        playerControls.Enable();

    }

    private void Update()
    {
        PlayerInput();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void PlayerInput()
    {
        // Access buttons from PlayerControls.inputactions
        playerPosition = playerControls.MoveHorizontal.Move.ReadValue<Vector2>();
        //Debug.Log("Player Position: " + playerPosition);
                                     // ^^^ Continuously called through Update()
                                     // to acess the player's coordinates.

    }

    private void Move()
    {
        playerRB.MovePosition(playerRB.position + playerPosition * (moveSpeed * Time.fixedDeltaTime));

    }  

}