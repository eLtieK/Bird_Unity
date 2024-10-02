using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bird;
    public GameObject missle;
    private MissileCounter missileCount;
    public AudioSource shoot;
    public float reload = 1.5f;
    public float timer = 1.5f;
    void Start()
    {
        missileCount = bird.GetComponent<MissileCounter>();
    }
    public void SpawnMissle()
    {
        Instantiate(missle, new Vector3(bird.transform.position.x, bird.transform.position.y, 0),transform.rotation);
    }
    public void ReloadAndShoot()
    {
        if (Input.GetKeyDown(KeyCode.J) && timer >= reload && missileCount.IsThereMissile())
        {
            SpawnMissle();
            shoot.Play();
            missileCount.LoseMissile();
            timer = 0;
        }
        else { timer += Time.deltaTime; }
    }
    void Update()
    {
        ReloadAndShoot();
    }
}
