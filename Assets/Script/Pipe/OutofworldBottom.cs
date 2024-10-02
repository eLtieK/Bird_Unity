using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutofworldBottom : MonoBehaviour
{
    public movement player;
    public LogicScript logic;
    public HealthCounter health;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<movement>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthCounter>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (!logic.over)
        {
            if (SceneManager.GetActiveScene().name == "PlayScreen" && health.liveRemaining > 0)
            {
                player.transform.position = new Vector3(0, 0, 0);
            }
            else if(SceneManager.GetActiveScene().name == "HardMode" && health.liveRemaining > 1)
            {
                player.transform.position = new Vector3(0, 0, 0);
            }
        }
    }
}
