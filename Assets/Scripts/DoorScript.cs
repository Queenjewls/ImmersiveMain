using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool isOpen = false;
    public float doorMoveSpeed = 5f;
    public Vector3 openPosition;  // Target position when the door is open
    private Vector3 closedPosition;  // Initial position, to keep track of where the door starts

    void Start()
    {
        closedPosition = transform.position;  // Store the starting position
    }

    // WRITTEN WITH THE USE OF CHATGPT!
    void Update()
    {
        if (isOpen)
        {
            // Move the door towards the open position
            transform.position = Vector3.MoveTowards(transform.position, openPosition, Time.deltaTime * doorMoveSpeed);
        }
        else
        {
            // Optionally, close the door (you can remove this else block if the door should stay open)
            transform.position = Vector3.MoveTowards(transform.position, closedPosition, Time.deltaTime * doorMoveSpeed);
        }
    }

    public void OpenDoor()
    {
        isOpen = true;
    }

    public void CloseDoor()
    {
        isOpen = false;
    }
}

