using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonController : MonoBehaviour
{
    public GameObject buttonVisual; // WRITTEN WITH THE USE OF CHATGPT!
    public GameObject door; // Reference to the door GameObject
    public float buttonPressX = 0.0f; // Amount the button is pressed along the X-axis
    public float buttonPressY = 0.0f; // Amount the button is pressed along the Y-axis
    public float buttonPressZ = 0.0f; // Amount the button is pressed along the Z-axis
    public float buttonPressDuration = 0.1f; // Duration for which the button remains visually pressed
    public float buttonResetDelay = 1.0f; // Delay before the button resets after the door is opened

    private bool isButtonPressed = false;
    private Vector3 buttonOriginalPosition;

    void Start()
    {
        buttonOriginalPosition = buttonVisual.transform.localPosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isButtonPressed && other.CompareTag("Hand"))
        {
            PressButton(); // Call the function to press the button
        }
    }

    void PressButton()
    {
        isButtonPressed = true;
        Vector3 pressedPosition = buttonOriginalPosition - new Vector3(buttonPressX, buttonPressY, buttonPressZ);
        buttonVisual.transform.localPosition = pressedPosition;
        Invoke("OpenDoor", buttonPressDuration); // Open the door after buttonPressDuration seconds
    }

    void OpenDoor()
    {
        door.SetActive(false); // Open the door by deactivating its GameObject
        Invoke("ResetButton", buttonResetDelay); // Reset the button after buttonResetDelay seconds
    }

    void ResetButton()
    {
        isButtonPressed = false;
        buttonVisual.transform.localPosition = buttonOriginalPosition; // Reset the button position
    }
}