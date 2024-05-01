using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnTouch : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!audioSource.isPlaying) // Check if the audio is not already playing
        {
            audioSource.Play(); // Play the sound
        }
    }
}
