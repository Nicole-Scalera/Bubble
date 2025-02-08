using System.Collections;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public GameObject playerCamera; // Reference to the mainCamera to be used
    public GameObject firstPlaySpawn; // Reference to where the player intially starts off in the beginning of the game
    Rigidbody2D playerRb; // Reference to the Players body
    public GameObject currentTarget; // Reference to the most immediate target that the Player has to reach which will act as save points
    private GameObject nextTarget; // Reference to following Target point after and this serves to ensure that everything is stored and able to function properly
    private GameObject nextSpawn; // Reference to the Spawn point that the player will be using for the Respawn (before the UpdatedRespawn)
    private UnityEngine.Vector2 currentSpawn; // Reference to the current save point that the player will spawn at when they die/hit an obstacle
    private void Awake() // Tried to make sure that things are staying the right way for the player when loading into the game
    {
        playerRb = GetComponent<Rigidbody2D>();
    }
    public void Start() // Wanted to make sure that the Start Point of the player is set first and stay that way & that the main camera stays with the player
    {
        firstPlaySpawn = GameObject.FindGameObjectWithTag("FirstStart");
        playerCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle")) //This tag is associated with Clouds for right now but can be used for any obstacles in the future depending if the tags need to be more specific
        {
            Die(); //Will clear the player object, spawn the player back at the last save point
        }
        if (collision.CompareTag("TargetReached")) //This is the tag for only when the targets are reached, basically serving as a save point for the player so that they don't have to hit anythign further than just the arrow keys
        {
            UpdateRespawnLocation();
        }
    }
    void Die()
    {
        StartCoroutine(Respawn(0.5f)); //This is important for the amount of time between the player dying and the spawning back on the screen
    }
    IEnumerator Respawn(float duration) // further breaks down what happens during respawn
    {
        playerRb.simulated = false;
        playerRb.velocity = new UnityEngine.Vector2(0, 0);
        transform.localScale = new UnityEngine.Vector2(0, 0);
        yield return new WaitForSeconds(duration);
        nextSpawn = GameObject.FindGameObjectWithTag("TargetReached").GetComponent<ChangeTarget>().nextTargetPoint; // Makes sure that there is a connection between the information stored within the Targets and shared to this script
        transform.position = currentSpawn; // Moves the player to the proper point 
        transform.localScale = new UnityEngine.Vector2(1, 1); // might need to be changed later as I think it might be changing the scale of the character after the first respawn of the player
        playerRb.simulated = true;
    }
    void UpdateRespawnLocation()
    {
        currentSpawn = currentTarget.transform.position; // Updates the current spawn point to the previous target point
        currentTarget = GameObject.FindGameObjectWithTag("TargetReached").GetComponent<ChangeTarget>().nextTargetPoint; // Updates the further target that is stored witin the ChangeTarget script and makes sure everything interconnects
        nextTarget = GameObject.FindGameObjectWithTag("TargetReached").GetComponent<ChangeTarget>().followingTargetPoint; // Updates the targets across the game, just insuring that there is the capability of multiple save points/spawn points that function whereever and whenever needed
    }
}
