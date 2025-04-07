using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInjectionProperty
{
    //Dependency Object should be Interface-Based
    public interface IActorDAL
    {
        List<Actor> SelectAllActors();



        

    }

    //This is the class that is responsible for Interacting with the Database
    //This class is going to be used by the ActorBL class
    //That means it is going to be the Dependency Object
    public class ActorDAL : IActorDAL
    {
        public List<Actor> SelectAllActors()
        {
            // Initializing the list of Actors with ID, Name, and Department
            List<Actor> ListActors = new List<Actor>
            {
                // new Actor() { ID = 1, Name = "Pranaya", Department = "IT" },
                // new Actor() { ID = 2, Name = "Kumar", Department = "HR" },
                // new Actor() { ID = 3, Name = "Rout", Department = "Payroll" }
            };
            return ListActors;
        }
    }
}


// public class Builder : IToolUser
// {

// 	private Hammer _hammer;
// 	private Hammer _saw;

// 	public void BuildHouse()
// 	{
// 		_Hammer.Use();
// 		Saw.Use();
// 		Console.WriteLine("House Built");

// 	}

// }