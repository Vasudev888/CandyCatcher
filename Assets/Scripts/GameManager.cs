using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int score = 0;
    public int lives = 3;
    bool isGameOver = false;
    public Text scoreText;
    
    private void Awake()
    {
        instance = this;
    }
    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void DecrementLives()
    {
        if(lives > 0)
        {
            lives--;
            print(lives);
        }

        if(lives <= 0)
        {
            isGameOver = true;
            GameOver();
        }
    }

    public void GameOver()
    {
        print("GameOver()");
    }
}
 