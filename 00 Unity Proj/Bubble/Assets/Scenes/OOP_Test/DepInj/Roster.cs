using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInjection
{
    // This class will act as the Program file that will initiate everything
    public class Roster : MonoBehaviour
    {
        public void PrintRoster() {
            //Create an Instance of ActorBL and Inject the Dependency Object as an Argument to the Constructor
            ActorBL actorBL = new ActorBL(new ActorDAL());
            List<Actor> ListActor = actorBL.GetAllActors();
            foreach (Actor act in ListActor)
            {
                Debug.Log($"ID = {act.ID}, Name = {act.Name}, Department = {act.Department}");
            }
            //Console.ReadKey();
        }
    }
}
