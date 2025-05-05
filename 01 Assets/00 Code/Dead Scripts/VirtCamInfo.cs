using System;
using UnityEngine;

// This is the VirtCamInfo class. It is a temporary script
// to keep the Virtual Camera in the scene from disappearing.

public class VirtCamInfo : MonoBehaviour
{
    // Create an instance of the GameManager so
    // that we can easily access it anywhere
    private static VirtCamInfo Instance;

    private void Awake()
    {
        // Ensure only one instance of GameManager exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

}