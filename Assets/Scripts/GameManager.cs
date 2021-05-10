using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int score = 0;
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
        print(score);
    }
}
