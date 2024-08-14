using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    /* this script won't run anything. it's js a collection of attributes and functions that will
     * be called from outside */

    public int score; // player's score
    public Text UIscore; // score displayed on the UI
    public GameObject gameOverScreen;
    public AudioSource ding;
    public AudioSource levelLostSFX;
    public bool gameContinue = true;

    [ContextMenu("Increase Score :3")]
    public void increaseScore(int addedScore) // this function will be called from outside this is why it's "public"
    {
        if (gameContinue)
        {
            score += addedScore; // add the score
            UIscore.text = score.ToString(); // update the UI score. converted toString from int
            ding.Play();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
     
    public void quitGame()
    {
        Application.Quit();
    }

    public void showGameOver()
    {
        if (gameContinue)
        {
            levelLostSFX.Play();
        }
        gameContinue = false;
        ding.enabled = false;
        gameOverScreen.SetActive(true);
    }
}
