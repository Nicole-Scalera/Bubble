using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class PlayerRespawn : MonoBehaviour
{
    public GameObject playerCamera;
    public GameObject thePlayer;
    public GameObject startSpawn;
    UnityEngine.Vector2 startPosition;
    Rigidbody2D playerRb;
    public GameObject currentTargetPoint;
    public GameObject nextTargetPoint;
    // Start is called before the first frame update
    private void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }
    public void Start()
    {
        startPosition = transform.position;
        playerCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TargetReached"))
        {
            UpdateRespawnLocation();
        }

        else if (collision.CompareTag("Obstacle"))
        {
            Die();
        }
    }
    void Die()
    {
        StartCoroutine(Respawn(0.5f));
    }
    IEnumerator Respawn(float duration)
    {
        playerRb.simulated = false;
        playerRb.velocity = new UnityEngine.Vector2(0,0);
        transform.localScale = new UnityEngine.Vector2(0,0);
        yield return new WaitForSeconds(duration);
        transform.position = startPosition;
        transform.localScale = new UnityEngine.Vector2(1,1);
        playerRb.simulated = true;
    }
    void UpdateRespawnLocation()
    {
        currentTargetPoint = nextTargetPoint;
        GetComponent<Rigidbody2D>().position = startPosition;
    }
}
