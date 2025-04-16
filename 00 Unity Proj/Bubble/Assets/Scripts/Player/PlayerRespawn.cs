using System.Collections;
using System.Numerics;
using UnityEditor.AssetImporters;
using UnityEngine;
using UnityEngine.InputSystem.Android;

public class PlayerRespawn : MonoBehaviour
{
    
    private Player player; // Player.cs
    
    // Reference to where the player intially starts off
    // in the beginning of the game
    private GameObject firstPlaySpawn;
    
    private Rigidbody2D playerRB; // Rigidbody Component

    // Reference to the most immediate target that the
    // Player has to reach which will act as save points
    private GameObject currentTarget;

    // Reference to following Target point after and
    // this serves to ensure that everything is stored
    // and able to function properly
    private GameObject nextTarget;

    // Reference to the Spawn point that the player
    // will be using for the Respawn (before the
    // UpdatedRespawn)
    private GameObject nextSpawn;

    // Reference to the current save point that the
    // player will spawn at when they die/hit an obstacle
    private UnityEngine.Vector2 currentSpawn;
    public int playerLives;
    private GameOver instanceOfGameOver;

    // Tried to make sure that things are staying the
    // right way for the player when loading into the game
    private void Awake()
    {
        player = Player.Instance; // Access Player.cs
    }

    // Wanted to make sure that the Start Point of the
    // player is set first and stay that way & that
    // the main camera stays with the player
    public void Start()
    {
        playerRB = player.GetRigidbody2D(); // RigidBody2D
        
        firstPlaySpawn = GameObject.FindGameObjectWithTag("FirstStart");

        firstPlaySpawn.transform.position = playerRB.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // This tag is associated with Clouds for right now
        // but can be used for any obstacles in the future
        // depending if the tags need to be more specific
        if (collision.CompareTag("Obstacle"))
        {
            // Will clear the player object, spawn the
            // player back at the last save point
            Die();
        }

        if (collision.CompareTag("TargetReached"))
        {

            // This is the tag for only when the targets are
            // reached, basically serving as a save point
            // for the player so that they don't have to hit
            // anything further than just the arrow keys
            UpdateCurrentRespawnLocation();
        }
    }
    void Die()
    {
        playerLives--;
        if (playerLives > 0)
        {
            // This is important for the amount of time between
            // the player dying and the spawning back on the screen
            StartCoroutine(RespawnCoroutine(0.5f));
        }
    }

    // Further breaks down what happens during respawn
    IEnumerator RespawnCoroutine(float duration)
    {
        playerRB.simulated = false;
        playerRB.velocity = new UnityEngine.Vector2(0, 0);
        transform.localScale = new UnityEngine.Vector2(0, 0);
        yield return new WaitForSeconds(duration);

        // Makes sure that there is a connection between
        // the information stored within the Targets and
        // shared to this script
        nextSpawn = GameObject.FindGameObjectWithTag("TargetReached").GetComponent<ChangeTarget>().nextTargetPoint;
        
        // Moves the player to the proper point
        transform.position = currentSpawn;

        // might need to be changed later as I think it
        // might be changing the scale of the character
        // after the first respawn of the player
        transform.localScale = new UnityEngine.Vector2(1, 1);
        playerRB.simulated = true;
    }
    void UpdateCurrentRespawnLocation()
    {
        // Updates the current spawn point to
        // the previous target point
        currentSpawn = currentTarget.transform.position;

        // Updates the further target that is
        // stored witin the ChangeTarget script
        // and makes sure everything interconnects
        currentTarget = GameObject.FindGameObjectWithTag("TargetReached").GetComponent<ChangeTarget>().nextTargetPoint;

        // Updates the targets across the game, just
        // insuring that there is the capability of
        // multiple save points/spawn points that
        // function whereever and whenever needed
        nextTarget = GameObject.FindGameObjectWithTag("TargetReached").GetComponent<ChangeTarget>().followingTargetPoint;
    }
}
