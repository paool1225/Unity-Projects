using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playGame : MonoBehaviour
{
    public void playLevel()
    {
        SceneManager.LoadSceneAsync("Level1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
