using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAudio : MonoBehaviour
{
    public AudioSource audioSource;
    private void Update()
    {

        if (PauseMenu.gameIsPaused)
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.volume = 0.01f;
        }
        else if (PauseMenu.gameIsPaused == false)
        {
            audioSource = GetComponent<AudioSource>();
            if (audioSource)
            {
                audioSource.volume = PlayerPrefsController.GetVolume();
            }
        }
    }
}
