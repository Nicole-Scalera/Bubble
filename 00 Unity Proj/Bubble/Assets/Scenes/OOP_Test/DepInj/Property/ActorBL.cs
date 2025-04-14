using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInjectionProperty
{
    //This is the Class that is going to consume the services provided by the IActorDAL Class
    //That means it is the Dependent Class which Depending on the IActorDAL Class
    public class ActorBL
    {
        public IActorDAL actorDAL;

        //Injecting the Dependency Object using Public Property
        public IActorDAL ActorDataObject
        {
            set
            {
                this.actorDAL = value;
            }
        }

        public List<Actor> GetAllActors()
        {
            return actorDAL.SelectAllActors();
        }
    }
}