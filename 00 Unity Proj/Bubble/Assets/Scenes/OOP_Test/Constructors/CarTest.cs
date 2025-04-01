using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is actually attached to
// the Car game object

public class CarTest : MonoBehaviour
{

    public Car car;

    void Start()
    {
        // Initialize myCar with the following values
        // in the Car constructor in Car.cs
        //Car myCar = new Car(2.5f, 3.5f, "Red", 10);
        car.PrintCarDetails(); // Print out the details regarding myCar
    }

    // Update is called once per frame
    void Update()
    {

    }
}
