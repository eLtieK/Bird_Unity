using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public Text highestText;
    private int playerHighestScore = 0;
    public bool showBoard = false;
    public GameObject gameOverScreen;
    public GameObject twoDigit;
    public GameObject oneDigit;
    public GameObject threeDigit;
    public AudioSource newRecord;
    public bool over = false;
    public GameObject howToPlay;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        updateHighestScore(playerScore);
    }
    public void updateHighestScore(int score)
    {
        if(score > playerHighestScore) 
        {
            newRecord.Play();
            playerHighestScore = score;
            if (SceneManager.GetActiveScene().name == "PlayScreen") { PlayerPrefs.SetInt("HighScore", score); }
            if (SceneManager.GetActiveScene().name == "HardMode") { PlayerPrefs.SetInt("HighScoreMissile", score); }
        }
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        showBoard = true;
        over = true;
        gameOverScreen.SetActive(true);
    }
    public void quitGame()
    {
        Application.Quit();
    }
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "PlayScreen" || SceneManager.GetActiveScene().name == "StartScreen")
        {
            highestText.text = PlayerPrefs.GetInt("HighScore").ToString();
            playerHighestScore = PlayerPrefs.GetInt("HighScore");
        }
        if(SceneManager.GetActiveScene().name == "HardMode" || SceneManager.GetActiveScene().name == "HowToPlay")
        {
            highestText.text = PlayerPrefs.GetInt("HighScoreMissile").ToString();
            playerHighestScore = PlayerPrefs.GetInt("HighScoreMissile");
        }
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "PlayScreen")
        {
            highestText.text = PlayerPrefs.GetInt("HighScore").ToString();
        }
        if (SceneManager.GetActiveScene().name == "HardMode")
        {
            highestText.text = PlayerPrefs.GetInt("HighScoreMissile").ToString();
        }
        if (playerScore >= 10 && playerScore < 100) { TwoDigitAppear(); }
        if (playerScore >= 100) { ThirdDigitAppear(); }
    }
    void TwoDigitAppear()
    {
        twoDigit.SetActive(true);
        oneDigit.SetActive(false);
    }
    void ThirdDigitAppear()
    {
        threeDigit.SetActive(true);
        twoDigit.SetActive(false);
        oneDigit.SetActive(false);
    }
    public void AppearHowToPlay()
    {
        howToPlay.SetActive(true);
    }
    public void Back()
    {
        howToPlay.SetActive(false);
    }
}
