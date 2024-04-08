using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenuUI;

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void ReStart()
    {
        Time.timeScale = 1f;
        FindObjectOfType<Loader>().LoadCurrentScene();
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        FindObjectOfType<Loader>().LoadOptionsMenu();
        gameIsPaused = false;
    }

    public void LoadStartScreenFromPauseMenu()
    {
        FindObjectOfType<Loader>().LoadStartScene();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
