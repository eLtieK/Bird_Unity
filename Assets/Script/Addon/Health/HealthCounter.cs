using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCounter : MonoBehaviour
{
    public Image[] lives;
    public int liveRemaining;
    public LogicScript logic;
    public AudioSource deadSound;
    public AudioSource heal;
    public AudioSource scoreBigAdd;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        liveRemaining = 1;
        lives[0].enabled = true;
        lives[1].enabled = false;
        lives[2].enabled = false;
    }
    public void LoseLife()
    {
        if (liveRemaining > 1)
        {
            lives[liveRemaining-1].enabled = false;
            liveRemaining--;
        }
    }
    public void AddLife()
    {
        if (liveRemaining < 3)
        {
            lives[liveRemaining].enabled = true;
            heal.Play();    
            liveRemaining++;
        }
        else
        {
            logic.addScore(3);
            scoreBigAdd.Play();
        }
    }
    public bool CheckDie()
    {
        if(liveRemaining == 1)
        {
            lives[liveRemaining-1].enabled = false;
            deadSound.Play();
            Debug.Log("DEAD");
            return true;
        }
        else { return false; }
    }
}
