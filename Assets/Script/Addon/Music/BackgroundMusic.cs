using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource music;
    public AudioClip[] songs;
    public AudioSource click;
    void Start()
    {
        music = GetComponent<AudioSource>();
        music.clip = songs[PlayerPrefs.GetInt("MusicSelected")];
        music.Play();
    }
    void Update()
    {
        if(PlayerPrefs.GetInt("MusicSelected") == 1)
        {
            music.volume = 0.25f;
        }
        else { music.volume = 0.5f; }
    }
    public void ChangeMusic()
    {
        music.Stop();
        music.clip = songs[PlayerPrefs.GetInt("MusicSelected")];
        music.Play();
    }
    public void Click()
    {
        click.Play();
    }
}
