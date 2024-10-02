using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiddleScan : MonoBehaviour
{
    public LogicScript logic;
    public movement bird;
    public MissileCounter missileCount;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<movement>();
        missileCount = GameObject.FindGameObjectWithTag("Player").GetComponent<MissileCounter>();
    } 

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3 && bird.birdIsAlive) 
        { 
            logic.addScore(1);
            if(SceneManager.GetActiveScene().name == "HardMode") { missileCount.AddMissile(); }
        }
    }
}
