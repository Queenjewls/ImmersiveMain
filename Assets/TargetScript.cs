using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public DoorScript doorScript;

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collider is tagged as "Ball"
        if (collision.gameObject.CompareTag("Ball"))
        {
            doorScript.OpenDoor();
        }
    }
}

