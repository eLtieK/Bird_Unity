using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paused : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenu;
    public movement bird;
    // Update is called once per frame
    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<movement>();
    }
    void Update()
    {
        if (bird.birdIsAlive == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (isPaused) { Resume(); }
                else { Pause(); }
            }
            if (Input.GetKeyDown(KeyCode.Space) && isPaused == true) { Resume(); }
        }
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        if(PlayerPrefs.GetInt("IsMuted") == 1) { AudioListener.volume = 0; }
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        if (PlayerPrefs.GetInt("IsMuted") == 1) { AudioListener.volume = 1; }
    }
    public void Again()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Resume();
    }
    public void Menu()
    {
        SceneManager.LoadScene("StartScreen");
        Resume();
    }
}
