using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInjectionProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an Instance of Client Class i.e. ActorBL 
            ActorBL actorBL = new ActorBL();

            //Inject the Dependency Object using the Public Property of the Client Class
            actorBL.ActorDataObject = new ActorDAL();

            List<Actor> ListActor = actorBL.GetAllEmployees();
            foreach (Actor act in ListActor)
            {
                //Console.WriteLine($"ID = {act.ID}, Name = {act.Name}, Department = {act.Department}");
            }
            //Console.ReadKey();
        }
    }
}