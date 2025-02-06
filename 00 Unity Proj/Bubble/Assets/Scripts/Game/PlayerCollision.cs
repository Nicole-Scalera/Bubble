using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudCollision : MonoBehaviour
{
    Rigidbody2D playerRigidbody;
    public SceneChanger sceneChanger; // Reference to the SceneChanger script
    public GameObject playerCamera;
    public UnityEngine.Vector2 respawnPosition;
    public GameObject savePoint;
    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }
    public void Start()
    {
        playerCamera = GameObject.FindGameObjectWithTag("Camera");
        respawnPosition = savePoint.transform.position;
    }
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
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
        playerRigidbody.simulated = false;
        playerRigidbody.velocity = new UnityEngine.Vector2(0,0);
        transform.localScale = new UnityEngine.Vector2(0,0);
        yield return new WaitForSeconds(duration);
        transform.position = respawnPosition;
        transform.localScale = new UnityEngine.Vector2(0,0);
        playerRigidbody.simulated = true;
    }
}
