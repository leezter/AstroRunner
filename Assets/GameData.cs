using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour
{
    public static GameData singleton;
    public Text scoreText = null;
    int score = 0;
    public Text highScore;
    
    void Awake()
    {
        GameObject [] gd = GameObject.FindGameObjectsWithTag("gamedata");

        if (gd.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
        singleton = this;

        PlayerPrefs.SetInt("score", 0);

        if (PlayerPrefs.HasKey("highscore"))
            highScore.text = "High Score: " + PlayerPrefs.GetInt("highscore");
        else
            highScore.text = "High Score: 0";
    }

    public void UpdateScore(int s)
    {
        score += s;
        PlayerPrefs.SetInt("score", score);
        if (scoreText != null)
            scoreText.text = "score: " + score;
    }
}
