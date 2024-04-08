using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    public int timeToWait = 5;

    int currentScene;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        if (currentScene == 0)
        {
            StartCoroutine(DelayLoad());
        }
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void LoadLevel4()
    {
        SceneManager.LoadScene("Level4");
    }

    public void LoadLevel5()
    {
        SceneManager.LoadScene("Level5");
    }

    public void LoadLevel6()
    {
        SceneManager.LoadScene("Level6");
    }

    public void LoadLevel7()
    {
        SceneManager.LoadScene("Level7");
    }

    public void LoadLevelInfinity()
    {
        SceneManager.LoadScene("Level Infinity");
    }


    public void LoadLevelsScreen()
    {
        SceneManager.LoadScene("Levels Menu");
    }

    public void LoadNextScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(currentScene + 1);
    }

    IEnumerator DelayLoad()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadGameOver()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game Over");
    }

    public void LoadStartScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartScreen");
    }

    public void LoadCurrentScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentScene);
    }

    public void LoadOptionsMenu()
    {
        SceneManager.LoadScene("Options Menu");
    }
}
