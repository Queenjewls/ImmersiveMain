using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public DoorScript doorScript;

    void OnCollisionEnter(Collision collision)
    {
        // WRITTEN WITH THE USE OF CHATGPT!
        if (collision.gameObject.CompareTag("Ball"))
        {
            doorScript.OpenDoor();
        }
    }
}

