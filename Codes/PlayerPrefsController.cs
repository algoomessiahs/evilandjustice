using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    const string VOLUME_KEY = "volume";
    const string DIFFICULTY_KEY = "difficulty";

    const float MIN_VOLUME = 0f;
    const float MAX_VOLUME = 1f;

    const float MIN_DIFFICULTY = 0f;
    const float MAX_DIFFICULTY = 4f;

    public static void SetVolume(float volume)
    {
        if (volume >= MIN_VOLUME && volume <= MAX_VOLUME)
        {
            PlayerPrefs.SetFloat(VOLUME_KEY, volume);
        }
        else
        {
            Debug.Log("Volume out of range");
        }
    }

    public static void SetDiffficulty(float difficulty)
    {
        if (difficulty >= MIN_DIFFICULTY && difficulty <= MAX_DIFFICULTY)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.Log("Difficulty setting is not in Range");
        }
    }

    public static float GetVolume()
    {
        return PlayerPrefs.GetFloat(VOLUME_KEY);
    }

    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }

}
