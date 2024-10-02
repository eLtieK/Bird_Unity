using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSelection : MonoBehaviour
{
    public Toggle toggle0, toggle1, toggle2, toggle3, toggle4, toggle5, toggle6, toggle7, toggle8;
    public BackgroundMusic music;
    void Start()
    {
        music = GameObject.FindGameObjectWithTag("Music").GetComponent<BackgroundMusic>();
    }
    void Awake()
    {
        if (PlayerPrefs.GetInt("MusicSelected") == 0)
        {
            toggle0.isOn = true;
            toggle1.isOn = false;
            toggle2.isOn = false;
            toggle3.isOn = false;
            toggle4.isOn = false;
            toggle5.isOn = false;
            toggle6.isOn = false;
            toggle7.isOn = false;
            toggle8.isOn = false;
        }
        else if (PlayerPrefs.GetInt("MusicSelected") == 1)
        {
            toggle0.isOn = false;
            toggle1.isOn = true;
            toggle2.isOn = false;
            toggle3.isOn = false;
            toggle4.isOn = false;
            toggle5.isOn = false;
            toggle6.isOn = false;
            toggle7.isOn = false;
            toggle8.isOn = false;
        }
        else if (PlayerPrefs.GetInt("MusicSelected") == 2)
        {
            toggle2.isOn = true;
            toggle1.isOn = false;
            toggle0.isOn = false;
            toggle3.isOn = false;
            toggle4.isOn = false;
            toggle5.isOn = false;
            toggle6.isOn = false;
            toggle7.isOn = false;
            toggle8.isOn = false;
        }
        else if (PlayerPrefs.GetInt("MusicSelected") == 3)
        {
            toggle3.isOn = true;
            toggle1.isOn = false;
            toggle2.isOn = false;
            toggle0.isOn = false;
            toggle4.isOn = false;
            toggle5.isOn = false;
            toggle6.isOn = false;
            toggle7.isOn = false;
            toggle8.isOn = false;
        }
        else if (PlayerPrefs.GetInt("MusicSelected") == 4)
        {
            toggle4.isOn = true;
            toggle1.isOn = false;
            toggle2.isOn = false;
            toggle3.isOn = false;
            toggle0.isOn = false;
            toggle5.isOn = false;
            toggle6.isOn = false;
            toggle7.isOn = false;
            toggle8.isOn = false;
        }
        else if (PlayerPrefs.GetInt("MusicSelected") == 5)
        {
            toggle5.isOn = true;
            toggle1.isOn = false;
            toggle2.isOn = false;
            toggle3.isOn = false;
            toggle4.isOn = false;
            toggle0.isOn = false;
            toggle6.isOn = false;
            toggle7.isOn = false;
            toggle8.isOn = false;
        }
        else if (PlayerPrefs.GetInt("MusicSelected") == 6)
        {
            toggle6.isOn = true;
            toggle1.isOn = false;
            toggle2.isOn = false;
            toggle3.isOn = false;
            toggle4.isOn = false;
            toggle5.isOn = false;
            toggle0.isOn = false;
            toggle7.isOn = false;
            toggle8.isOn = false;
        }
        else if (PlayerPrefs.GetInt("MusicSelected") == 7)
        {
            toggle7.isOn = true;
            toggle1.isOn = false;
            toggle2.isOn = false;
            toggle3.isOn = false;
            toggle4.isOn = false;
            toggle5.isOn = false;
            toggle6.isOn = false;
            toggle0.isOn = false;
            toggle8.isOn = false;
        }
        else if (PlayerPrefs.GetInt("MusicSelected") == 8)
        {
            toggle8.isOn = true;
            toggle1.isOn = false;
            toggle2.isOn = false;
            toggle3.isOn = false;
            toggle4.isOn = false;
            toggle5.isOn = false;
            toggle6.isOn = false;
            toggle7.isOn = false;
            toggle0.isOn = false;
        }
    }
    public void ChooseMusic0()
    {
        PlayerPrefs.SetInt("MusicSelected", 0);
        music.ChangeMusic();
    }
    public void ChooseMusic1()
    {
        PlayerPrefs.SetInt("MusicSelected", 1);
        music.ChangeMusic();
    }
    public void ChooseMusic2()
    {
        PlayerPrefs.SetInt("MusicSelected", 2);
        music.ChangeMusic();
    }
    public void ChooseMusic3()
    {
        PlayerPrefs.SetInt("MusicSelected", 3);
        music.ChangeMusic();
    }
    public void ChooseMusic4()
    {
        PlayerPrefs.SetInt("MusicSelected", 4);
        music.ChangeMusic();
    }
    public void ChooseMusic5()
    {
        PlayerPrefs.SetInt("MusicSelected", 5);
        music.ChangeMusic();
    }
    public void ChooseMusic6()
    {
        PlayerPrefs.SetInt("MusicSelected", 6);
        music.ChangeMusic();
    }
    public void ChooseMusic7()
    {
        PlayerPrefs.SetInt("MusicSelected", 7);
        music.ChangeMusic();
    }
    public void ChooseMusic8()
    {
        PlayerPrefs.SetInt("MusicSelected", 8);
        music.ChangeMusic();
    }
}
