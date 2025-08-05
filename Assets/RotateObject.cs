using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [Header("Rotation Settings")]
    public float rotationSpeed = 90f; // Degrees per click
    public GameObject markerParent;   // The AR marker that holds your spawned model

    // Rotate Left
    public void RotateLeft()
    {
        GameObject targetObject = GameObject.FindGameObjectWithTag("object");
        if (targetObject != null)
        {
            targetObject.transform.Rotate(Vector3.up, -rotationSpeed);
        }
        else
        {
            Debug.LogWarning("No GameObject with tag 'object' found in the scene.");
        }
    }




    // Rotate Right
    public void RotateRight()
    {
        GameObject targetObject = GameObject.FindGameObjectWithTag("object");
        if (targetObject != null)
        {
            targetObject.transform.Rotate(Vector3.up, rotationSpeed);
        }
        else
        {
            Debug.LogWarning("No GameObject with tag 'object' found in the scene.");
        }
    }


}
