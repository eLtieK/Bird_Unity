using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawn : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;
    public HealthCounter health;
    public AudioSource heal;
    public movement bird;
    // Update is called once per frame
    void Update()
    {
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthCounter>();
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<movement>();
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Debug.Log("Health Deleted");
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pipe")
        {
            Destroy(gameObject);
            Debug.Log("Health Crash Deleted");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (bird.birdIsAlive) 
            {
                health.AddLife();
            }
            Destroy(gameObject);
            Debug.Log("Heal Success");
        }
    }
}
