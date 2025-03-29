using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTarget : MonoBehaviour
{
    /*This script was made in order to give the Targets that the player passes over so there is an exchange of information to the PlayerRespawn script attached the player
    */
    public GameObject nextTargetPoint; //Stores the very next save point the player has to reach within the Target Object
    public GameObject followingTargetPoint; //Stores the save point after the last one so that there is an easier transfer of information without having to write long extensive code

}
