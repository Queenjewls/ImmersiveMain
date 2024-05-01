using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTargetController : MonoBehaviour
{
    // WRITTEN WITH THE USE OF CHATGPT!
    public GameObject door;

    // End position for the door when it's fully opened
    public Vector3 endPosition;

    // Speed at which the door opens
    public float openingSpeed = 2f;

    // Reference to the target GameObject
    public GameObject target;

    // Number of balls required to trigger the door
    public int ballsRequired = 2;

    // Counter for the number of balls landed on the target
    private int ballsLanded = 0;

    // Flag to track whether the door is currently opening
    private bool isOpening = false;

    // Update is called once per frame
    void Update()
    {
        // If the required number of balls have landed on the target, open the door
        if (ballsLanded >= ballsRequired && !isOpening)
        {
            OpenDoor();
        }

        // If the door is currently opening, continue opening it
        if (isOpening)
        {
            // Calculate the new position based on the opening speed
            float step = openingSpeed * Time.deltaTime;
            door.transform.position = Vector3.MoveTowards(door.transform.position, endPosition, step);

            // If the door has reached its end position, stop opening
            if (door.transform.position == endPosition)
            {
                isOpening = false;
            }
        }
    }

    // Method to open the door
    void OpenDoor()
    {
        isOpening = true;
        Debug.Log("Opening door...");
    }

    // Method called when a ball is dropped onto the target
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ballsLanded++;
        }
    }
}
