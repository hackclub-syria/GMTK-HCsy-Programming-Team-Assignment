using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
    public Text highScore;
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        highScore.text = "High Score: " + PlayerPrefs.GetInt("High Score").ToString();
    }
    public void UpdateHighScore()
    {
        int high = PlayerPrefs.GetInt("High Score");
        if (logic.playerScore > high)
        {
            PlayerPrefs.SetInt("High Score", logic.playerScore);
            highScore.text = "High Score: " + logic.playerScore.ToString();
            highScore.color = Color.green;
        }
    }
}
