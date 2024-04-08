using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{

    public Slider volumeSlider;
    public float defaultVolume = 0.7f;

    public Slider difficultySlider;
    public float defaultDifficulty = 1f;


    void Start()
    {
        volumeSlider.value = PlayerPrefsController.GetVolume();
        difficultySlider.value = PlayerPrefsController.GetDifficulty();
    }


    public void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();

        if (musicPlayer)
        {
            musicPlayer.SetVolume(volumeSlider.value);
        }
        else
        {
            Debug.Log("No music player found, Did you start from splash screen?");
        }
    }

    public void SaveAndExit()
    {
        PlayerPrefsController.SetVolume(volumeSlider.value);
        PlayerPrefsController.SetDiffficulty(difficultySlider.value);
        FindObjectOfType<Loader>().LoadStartScene();
    }

    public void SetDefault()
    {
        volumeSlider.value = defaultVolume;
        difficultySlider.value = defaultDifficulty;
    }
}
