using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public AudioSource jumpSound;
    private bool haveDie = false;
    public AudioSource losingSound;
    public HealthCounter health;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Ken";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
            jumpSound.Play();
        }
        if(birdIsAlive == false && haveDie == false) 
        {
            haveDie = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && haveDie) //Space de cho nhanh
        { 
            logic.restartGame(); 
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdIsAlive)
        {
            if (collision.gameObject.tag == "Pipe")
            {
                if (health.CheckDie())
                {
                    logic.gameOver();
                    birdIsAlive = false;
                }
                else
                {
                    health.LoseLife();
                    losingSound.Play();
                }
            }
        }
    }
}
