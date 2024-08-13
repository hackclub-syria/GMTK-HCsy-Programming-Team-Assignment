using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreCounter;
    public GameObject gameOverScreenUI;
    public PlayerData playerData;
    public GameObject birdie;
    public Sprite deadBird;
    public bool birdieIsBreathing = true;
    [ContextMenu("Increment Score")]
    void Start()
    {
        playerData = GameObject.FindGameObjectWithTag("Player Data").GetComponent<PlayerData>();
        scoreCounter.text = playerScore.ToString();
        Time.timeScale = 1;
    }
    public void AddScore(int scoreIncrement)
    {
        playerScore += scoreIncrement;
        scoreCounter.text = playerScore.ToString();
        playerData.UpdateHighScore();
    }
    public void RestartTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        gameOverScreenUI.SetActive(true);
        birdieIsBreathing = false;
        birdie.GetComponent<SpriteRenderer>().sprite = deadBird;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
