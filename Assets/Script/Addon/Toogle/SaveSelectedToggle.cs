using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveSelectedToggle : MonoBehaviour
{
    public Toggle toggle1;
    public ToggleGroup allowSwitch;
    void Awake()
    {
        if (AudioListener.volume == 0)
        {
            toggle1.isOn = true;
        }
        else { toggle1.isOn = false; }
    }
}