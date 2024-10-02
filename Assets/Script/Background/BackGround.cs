using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackGround : MonoBehaviour
{
    public BackgroundDataBase backgroundDB;

    public SpriteRenderer artworkSprite;
    private int selectedOption = 0;
    private int lastScreen = 0;
    private bool haveChange = false;
    private bool startScreen = true;
    private int isAuto = 1;
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        if (!PlayerPrefs.HasKey("selectedOptionBackground")) { selectedOption = 0; }
        else { Load(); }
        UpdateBackground(selectedOption);
    }
    void Update()
    {
        isAuto = PlayerPrefs.GetInt("isAuto");
        if (isAuto == 1)
        {
            if (logic.playerScore % 5 == 0 && !haveChange)
            {
                GetNewScreen();
                haveChange = true;
            }
            else if (haveChange && logic.playerScore % 5 != 0) { haveChange = false; startScreen = false; }
        }
    }
    private void UpdateBackground(int selectedOption)
    {
        BackgroundSelection background = backgroundDB.GetBackground(selectedOption);
        artworkSprite.sprite = background.backgroundSprite;
    }
    public void GetNewScreen()
    {
        if (!startScreen)
        {
            while (lastScreen == selectedOption)
            {
                selectedOption = Random.Range(0, backgroundDB.BackgroundCount - 1);
            }
            lastScreen = selectedOption;
            UpdateBackground(selectedOption);
        }
        else
        {
            UpdateBackground(selectedOption);
        }
    }
    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOptionBackground");
        lastScreen = selectedOption;
    }
    public void ChangeToBackground()
    {
        Save();
        SceneManager.LoadScene(3);
    }
    public void ChangeToSkin()
    {
        Save();
        SceneManager.LoadScene(2);
    }
    private void Save()
    {
        PlayerPrefs.SetInt("selectedOptionBackground", selectedOption);
    }
    public void ChangeAuto()
    {
        if (isAuto == 1){ isAuto = 0; }
        else { isAuto = 1; }
        PlayerPrefs.SetInt("isAuto", isAuto);
    }
}
