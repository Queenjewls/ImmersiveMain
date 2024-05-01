
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class DoorScript2 : MonoBehaviour
{
    public Transform doorTransform;       // Assign the actual door transform that should move
    public Vector3 openPosition;          // Manually set this in the Inspector to the desired open position
    public float doorOpenSpeed = 5f;      // Speed at which the door opens

    private void OnCollisionEnter(Collision collision)
    {
        // WRITTEN WITH THE USE OF CHATGPT!
        if (collision.gameObject.CompareTag("Key"))
        {
            StartCoroutine(OpenDoor());
        }
    }

    private IEnumerator OpenDoor()
    {
        while (Vector3.Distance(doorTransform.position, openPosition) > 0.01f) // Added a small threshold to ensure smooth stopping
        {
            doorTransform.position = Vector3.MoveTowards(doorTransform.position, openPosition, Time.deltaTime * doorOpenSpeed);
            yield return null;
        }
    }
}

