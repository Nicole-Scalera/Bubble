using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is not attached to the Car game object, but is utilized by CarTest to
// initialize an instance of the class. Specifically, it utilizes the Car() constructor,
// which parses in four (4) values. These values are then printed out using PrintCarDetails().

[System.Serializable]
public class Car
{

    // Variables for the car
    private float speedX;
    private float speedY;

    public string color;
    public int highestSpeed;


    // Car constructor, including the X & Y speeds,
    // the color, and the highest speed
    public Car(float speedX, float speedY, string color, int highestSpeed)
    {
        this.speedX = speedX;
        this.speedY = speedY;
        this.color = color;
        this.highestSpeed = highestSpeed;
        Debug.Log("Car(speedX, speedY, color, highestSpeed) Called");
    }

    // Call to print details in console
    public void PrintCarDetails()
    {
        Debug.Log("Speed X: " + speedX);
        Debug.Log("Speed X: " + speedY);
        Debug.Log("Color: " + color);
        Debug.Log("HighestSpeed: " + highestSpeed);
    }

}
