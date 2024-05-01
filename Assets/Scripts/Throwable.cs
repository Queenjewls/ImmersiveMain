using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour

{
    // WRITTEN WITH THE USE OF CHATGPT!
    public GameObject door;

    // Number of targets to hit
    public int numberOfTargets = 3;

    // Counter for the number of targets hit
    private int targetsHit = 0;

    // Update is called once per frame
    void Update()
    {
        // Check if all targets have been hit
        if (targetsHit >= numberOfTargets)
        {
            OpenDoor();
        }
    }

    // Method to open the door
    void OpenDoor()
    {
        // Implement your door opening logic here
        Debug.Log("Opening door...");
        // Example: door.GetComponent<Animator>().SetTrigger("Open");
    }

    // Method called when a sword hits a target
    void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to a sword
        if (other.CompareTag("Sword"))
        {
            // Increment the targetsHit counter
            targetsHit++;
            // Optionally, you can disable the sword to prevent it from hitting other targets
            other.gameObject.SetActive(false);
        }
    }
}


