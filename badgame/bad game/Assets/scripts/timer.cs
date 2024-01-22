using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class timer : MonoBehaviour
{
    public TextMeshProUGUI Timer;

    public float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        UpdateTime(timeRemaining);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTime(timeRemaining);
        }
        else
        {
            UpdateTime(0);
            SceneManager.LoadSceneAsync("GameOver");
        }
        
    }
    public void UpdateTime(float timeLeft)
    {
        Timer.text = "Time Remaining: " + timeLeft;
    }
    

}
