using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInjectionConstructor
{
    //This is going to be our Model class which holds the Model data
    //This class is going to be used by both ActorDAL and ActorBL
    public class Actor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
}
