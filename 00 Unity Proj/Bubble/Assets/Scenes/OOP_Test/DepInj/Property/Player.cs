using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInjectionProperty
{
    //Dependency Object should be Interface-Based
    public interface IPlayerInfo
    {
        // void PlayerMovement();
        // void Position();
        // void Speed();
        // void PlayerControls();
        // void PlayerRB();
    }

    //This is the class that is responsible for Interacting with the Database
    //This class is going to be used by the ActorBL class
    //That means it is going to be the Dependency Object
    public class Player : IPlayerInfo
    {

        // private Position _position;
        // private Saw _saw;

    }
}