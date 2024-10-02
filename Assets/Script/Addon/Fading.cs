using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fading : MonoBehaviour
{
    public CanvasGroup myUI;
    private int haveFade = 1;
    void Start()
    {
        haveFade = PlayerPrefs.GetInt("haveFade");
        if(haveFade == 1) { myUI.alpha = 1; }
        else { myUI.alpha = 0.5f; }
    }
    // Update is called once per frame
    public void Apply()
    {
        if (haveFade == 1)
        {
            myUI.alpha = 0.5f;
            haveFade = 0;
        }
        else
        {
            myUI.alpha = 1;
            haveFade = 1;
        }
        PlayerPrefs.SetInt("haveFade", haveFade);
    }
}
