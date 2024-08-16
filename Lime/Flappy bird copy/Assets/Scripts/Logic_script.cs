using System.Security.AccessControl;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System; 

public class Logic_script : MonoBehaviour
{
    public float Score, High_score;
    public SpriteRenderer Wings_renderer;
    public Sprite Wing1, Wing2;
    public TextMeshProUGUI Score_text, High_score_text;
    public GameObject Game_over_screen;

     void Start()
    {
        High_score = PlayerPrefs.GetFloat("High_score");
        int High_score_int = (int)Math.Round(High_score);
        High_score_text.text = High_score_int.ToString(); 
    }
    public void Add_score(float Increase)
    {
        Score += Increase;
        int Score_int = (int)Math.Round(Score);
        Score_text.text = Score_int.ToString();

        if (Score > High_score)
        {
            High_score = Score;
            PlayerPrefs.SetFloat("High_score", High_score); 
            int High_score_int = (int)Math.Round(High_score);
            High_score_text.text = High_score_int.ToString(); 
        }
    }
    public void Restart_game()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Quit_game()
    {
        PlayerPrefs.SetFloat("High_score", 0);
        Application.Quit();
    }
    public void Game_over()
    {
        Time.timeScale = 0;
        Game_over_screen.SetActive(true);
        PlayerPrefs.Save();
    }
    public void Flap()
    {
        if (Wings_renderer.sprite == Wing1) Wings_renderer.sprite = Wing2;
        else  Wings_renderer.sprite = Wing1;
    }
}
