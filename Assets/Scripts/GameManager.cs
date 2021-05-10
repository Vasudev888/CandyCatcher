using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public PlayerController playerController;
    public static GameManager instance;
    public GameObject livesHolder;
    public GameObject gameOverPanel;

    int score = 0;
    public int lives = 3;
    bool gameOver = false;
    public Text scoreText;
    
    private void Awake()
    {
        instance = this;
    }
    public void IncrementScore()
    {
        if(!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
        }
    }

    public void DecrementLives()
    {
        if(lives > 0)
        {
            lives--;
            print(lives);
            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);
        }

        if(lives <= 0)
        {
            gameOver = true;
            GameOver();
        }
    }

    public void GameOver()
    {
        CandySpawner.instance.StopSpawningCandy();

        //GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;
        playerController.canMove = false;
        gameOverPanel.SetActive(true);
        print("GameOver()");
    }
}
 