using System;
using UnityEngine;

// This is the PlayerInfo class. It encapsulates general data and info about
// the Player game object, which is utilized throughout other scripts.

public class Player : MonoBehaviour
{
    // Singleton instance for global reference
    private static Player _player;

    // Constructor that forces only a single
    // instance of Player to be created
    public static Player Character
    {
        get
        {
            // If Player instance is null, assign Player component
            if (_player == null)
            {
                _player = GameObject.Find("Player").GetComponent<Player>();
            }

             // Return the Player instance
            return _player;
        }
    }
    
    // Singleton instance for global reference
    private static PlayerControls _controls;
    
    // Constructor that forces only a single
    // instance of PlayerControls to be created
    public static PlayerControls Controls
    {
        get
        {
            // If Controls are null, create a new instance
            if (_controls == null)
            {
                _controls = new PlayerControls(); // Access movement controls
            }

            // Return the PlayerControls instance
            return _controls;
        }
    }
}
