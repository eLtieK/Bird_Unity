using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveScreen : MonoBehaviour
{
    // Start is called before the first frame update\
    public string playScreen;
    public string skinScreen;
    public string mainScreen;
    public string musicScreen;
    public string hardMode;
    public string howToPlay;
    public bool havePlay = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && havePlay == false)
        {
            if (SceneManager.GetActiveScene().name == "HowToPlay") { HardMode(); }
            else
            {
                SceneManager.LoadScene(playScreen);
            }
            havePlay = true;
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene(playScreen);
        havePlay = true;
    }
    public void SkinScreen()
    {
        SceneManager.LoadScene(skinScreen);
        havePlay = false;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(mainScreen);
    }
    public void MusicScreen()
    {
        SceneManager.LoadScene(musicScreen);
    }
    public void HardMode()
    {
        SceneManager.LoadScene(hardMode);
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene(howToPlay);
    }
}
