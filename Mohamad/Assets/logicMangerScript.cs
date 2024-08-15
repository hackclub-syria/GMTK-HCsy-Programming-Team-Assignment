using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicMangerScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject GameOverScreen;
    [ContextMenu("increase score")]
    public void addscore(int scoreToAdd){
        score = score + scoreToAdd;
        scoreText.text = score.ToString();

    }
    public void restartScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver(){
        GameOverScreen.SetActive(true);



    }

}
