using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteSound : MonoBehaviour
{
    public void MuteHandler(bool mute)
    {
        if (mute)
        {
            AudioListener.volume = 0;
            PlayerPrefs.SetInt("IsMuted", 0);
        }
        else
        {
            AudioListener.volume = 1;
            PlayerPrefs.SetInt("IsMuted", 1);
        }
    }
}
