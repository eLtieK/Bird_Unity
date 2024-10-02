using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackgroundManager : MonoBehaviour
{
    public BackgroundDataBase backgroundDB;

    public SpriteRenderer artworkSprite;
    private int isAuto = 1;
    private int selectedOption = 0;
    private int lastScreen = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOptionBackground")) { selectedOption = 0; }
        else { Load(); }
        UpdateBackground(selectedOption);
    }
    private void UpdateBackground(int selectedOption)
    {
        BackgroundSelection background = backgroundDB.GetBackground(selectedOption);
        artworkSprite.sprite = background.backgroundSprite;
    }
    public void GetNewScreen()
    {
        while (lastScreen != selectedOption)
        {
            selectedOption = Random.Range(0, backgroundDB.BackgroundCount - 1);
        }
        lastScreen = selectedOption;
        UpdateBackground(selectedOption);
    }
    public void NextOption()
    {
        selectedOption++;
        if (selectedOption >= backgroundDB.BackgroundCount)
        {
            selectedOption = 0;
        }
        UpdateBackground(selectedOption);
        Save();
    }

    public void BackOption()
    {
        selectedOption--;
        if (selectedOption < 0)
        {
            selectedOption = backgroundDB.BackgroundCount - 1;
        }
        UpdateBackground(selectedOption);
        Save();
    }
    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOptionBackground");
        isAuto = PlayerPrefs.GetInt("isAuto");
    }

    private void Save()
    {
        PlayerPrefs.SetInt("selectedOptionBackground", selectedOption);
    }
    public void ChangeToSkin()
    {
        SceneManager.LoadScene(2);
    }
    public void ChangeAuto()
    {
        if (isAuto == 1) { isAuto = 0; }
        else { isAuto = 1; }
        PlayerPrefs.SetInt("isAuto", isAuto);
    }
}
