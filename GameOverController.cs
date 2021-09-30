using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject TapToStart;
    public GameObject ScoreText;

    private void Start()
    {
        gameOverPanel.SetActive(false);
        TapToStart.SetActive(true);
        ScoreText.SetActive(false);

        PauseGame();
    }


    private void Update()
    {
        if (Input.touchCount > 0)
        {
            StartGame();

        }
    }
    public void GameOver()
    {
        ScoreText.SetActive(false);
        gameOverPanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene 1");
    }
    public void Restart2()
    {
        SceneManager.LoadScene("Second");
    }

    public void Restart3()
    {
        SceneManager.LoadScene("Third");
    }

    public void Restart4()
    {
        SceneManager.LoadScene("Four");
    }

    public void Restart5()
    {
        SceneManager.LoadScene("Five");
    }













    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        ScoreText.SetActive(true);
        TapToStart.SetActive(false);
        Time.timeScale = 1f;
    }
}
