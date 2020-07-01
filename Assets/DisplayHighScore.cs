using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHighScore : MonoBehaviour
{
    public Text highScore;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("highscore"))
            highScore.text = "High Score: " + PlayerPrefs.GetInt("highscore");
        else
            highScore.text = "High Score: 0";
    }
}
