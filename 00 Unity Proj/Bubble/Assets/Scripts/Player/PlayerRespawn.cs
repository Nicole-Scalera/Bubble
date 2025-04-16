using System.Collections;
// using System.Numerics;
// using Unity.VisualScripting;
// using UnityEditor.AssetImporters;
using UnityEngine;
// using UnityEngine.InputSystem.Android;
// using Vector2 = System.Numerics.Vector2;

public class PlayerRespawn : MonoBehaviour
{
    private Player player; // Player.cs
    private GameManager gameManager; // GameManager.cs
    
    private void Awake()
    {
        player = Player.Instance; // Access Player.cs
        gameManager = GameManager.Instance;
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
    }
    void Die()
    {
        // Call the RestartGame() method
        // from the GameManager
        GameManager.Instance.RestartGame();
    }
}
