using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uiManager : MonoBehaviour
{

    public Text scoreText;
    bool gameOver;
    int score;


    void Start()
    {
        gameOver = false;
        score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 1.0f);
    }

    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    void scoreUpdate()
    {
        if (gameOver == false)
        {
            score += 1;
        }
        
    }


    public void gameOverOn()
    {
        gameOver = true;
    }


    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    

    public void Pause()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }


}
