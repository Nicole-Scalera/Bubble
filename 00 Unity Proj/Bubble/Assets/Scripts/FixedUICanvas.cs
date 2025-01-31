using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUICanvas : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    void Start()
    {
        // Store the initial position and rotation of the UI Canvas
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    void LateUpdate()
    {
        // Keep the UI Canvas fixed in world space
        transform.position = initialPosition;
        transform.rotation = initialRotation;
    }
}