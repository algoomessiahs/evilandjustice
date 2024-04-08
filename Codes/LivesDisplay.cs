using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LivesDisplay : MonoBehaviour
{

    public float normalLives = 4;
    public int sublives = 1;
    
    float lives = 3;
    TextMeshProUGUI livesText;

    private void Start()
    {
        if (PlayerPrefsController.GetDifficulty() == 0)
        {
            lives = 7;
        }
        else if (PlayerPrefsController.GetDifficulty() == 1)
        {
            lives = 4;
        }
        else if (PlayerPrefsController.GetDifficulty() == 2)
        {
            lives = 3;
        }
        else if (PlayerPrefsController.GetDifficulty() == 3)
        {
            lives = 2;
        }
        else if (PlayerPrefsController.GetDifficulty() == 4)
        {
            lives = 1;
        }
        livesText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public void DecreseHealth()
    {
        lives -= sublives;
        UpdateDisplay();

        if (lives <= 0)
        {
            FindObjectOfType<LevelController>().SetGameLoseTrue();
        }

    }

}
