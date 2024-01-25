using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Instructions");

    }
    public void StartLevel()
    {
        SceneManager.LoadSceneAsync("Level");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ReplayGame()
    {
        SceneManager.LoadSceneAsync("Level");
    }
    public void BackToMain()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
