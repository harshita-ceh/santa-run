using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject GameoverPanel;
    public Text scoretext;
    int score = 0;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public void GameOver()
    {
        ObstacleSpawner.instance.gameOver = true;
        StopScrolling();
        GameoverPanel.SetActive(true);
    }
    void StopScrolling()
    {
       TextureScroll[] scrollingObjects = FindObjectsOfType<TextureScroll>();
        foreach (TextureScroll t in scrollingObjects)
        {
            t.scroll = false;
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void IncrementScore()
    {
        score++;
        scoretext.text = score.ToString();
    }
}
