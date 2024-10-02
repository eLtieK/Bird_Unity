using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissileCounter : MonoBehaviour
{
    public Image[] missile;
    public int missileRemaining;
    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        missileRemaining = 1;
        missile[0].enabled = true;
        missile[1].enabled = false;
        missile[2].enabled = false;
    }
    public void LoseMissile()
    {
        if (missileRemaining >= 1)
        {
            missile[missileRemaining - 1].enabled = false;
            missileRemaining--;
        }
    }
    public void AddMissile()
    {
        if (missileRemaining < 3)
        {
            missile[missileRemaining].enabled = true;
            missileRemaining++;
        }
    }
    public bool IsThereMissile()
    {
        if(missileRemaining < 1) { return false; }
        else { return true; }
    }
}
