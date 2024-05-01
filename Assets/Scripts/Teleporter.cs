using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform player; // Assign this from the inspector
    public Vector3 startPosition; // Set the starting position from the inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            player.position = startPosition; // Teleport the player to the start position
        }
    }
}

