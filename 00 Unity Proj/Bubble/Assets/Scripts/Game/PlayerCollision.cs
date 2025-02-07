using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudCollision : MonoBehaviour
{
    Rigidbody2D playerRigidbody;
    public GameObject thePlayer;
    public SceneChanger sceneChanger; // Reference to the SceneChanger script
    public GameObject playerCamera;
    public GameObject saveNspawnPoint;
    public GameObject NewSavePoint;
    public GameObject playerStartGamePoint;
    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }
    public void Start()
    {
        playerCamera = GameObject.FindGameObjectWithTag("Camera");
        playerStartGamePoint = saveNspawnPoint;
    }
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Die();
        }

        if (collision.CompareTag("TargetReached"))
        {
            UpdateRespawn();
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
        transform.localScale = new UnityEngine.Vector2(0,0);
        playerRigidbody.simulated = true;
    }

    void UpdateRespawn()
    {
        NewSavePoint = saveNspawnPoint;
    }
}
