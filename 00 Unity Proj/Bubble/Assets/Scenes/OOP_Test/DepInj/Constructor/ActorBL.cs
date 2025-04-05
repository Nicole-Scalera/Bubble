using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInjectionConstructor
{
    //Client Class or Dependent Object
    //This is the Class that is going to consume the services provided by the IActorDAL Class
    //That means it is the Dependent Class which Depending on the IActorDAL Class
    public class ActorBL
    {
        public IActorDAL actorDAL;

        //Injecting the Dependency Object using Constructor means it is a Loose Coupling
        public ActorBL(IActorDAL actorDAL)
        {
            this.actorDAL = actorDAL;
        }

        public List<Actor> GetAllActors()
        {
            return actorDAL.SelectAllActors();
        }
    }
}
