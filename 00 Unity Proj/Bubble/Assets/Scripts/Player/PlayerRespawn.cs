using System.Collections;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public GameObject playerCamera;
    public GameObject firstPlaySpawn;
    Rigidbody2D playerRb;
    public GameObject currentTarget;
    private GameObject nextTarget;
    private GameObject nextSpawn;
    private UnityEngine.Vector2 currentSpawn;
    // Start is called before the first frame update
    private void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }
    public void Start()
    {
        firstPlaySpawn = GameObject.FindGameObjectWithTag("FirstStart");
        playerCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Die();
        }
        if (collision.CompareTag("TargetReached"))
        {
            UpdateRespawnLocation();
        }
    }
    void Die()
    {
        StartCoroutine(Respawn(0.5f));
    }
    IEnumerator Respawn(float duration)
    {
        playerRb.simulated = false;
        playerRb.velocity = new UnityEngine.Vector2(0, 0);
        transform.localScale = new UnityEngine.Vector2(0, 0);
        yield return new WaitForSeconds(duration);
        nextSpawn = GameObject.FindGameObjectWithTag("TargetReached").GetComponent<ChangeTarget>().nextTargetPoint;
        transform.position = currentSpawn;
        transform.localScale = new UnityEngine.Vector2(1, 1);
        playerRb.simulated = true;
    }
    void UpdateRespawnLocation()
    {
        currentSpawn = currentTarget.transform.position;
        currentTarget = GameObject.FindGameObjectWithTag("TargetReached").GetComponent<ChangeTarget>().nextTargetPoint;
        nextTarget = GameObject.FindGameObjectWithTag("TargetReached").GetComponent<ChangeTarget>().followingTargetPoint;
    }
}
