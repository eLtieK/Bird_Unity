using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawner : MonoBehaviour
{
    public GameObject heart;
    public HealthSpawn heartLogic;
    public float SpawnRate = 20;
    private float timer = 0;
    public float heightOffSet = 7;
    // Start is called before the first frame update
    void Start()
    {
        heartLogic.moveSpeed = 5;
        heartLogic = heart.GetComponent<HealthSpawn>();
    }
    void SpawnHeart()
    {
        float lowestPoint = transform.position.y - heightOffSet;
        float highestPoint = transform.position.y + heightOffSet;
        Instantiate(heart, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate) { timer += Time.deltaTime; }
        else 
        { 
            SpawnHeart(); 
            timer = 0; 
            SpawnRate = Random.Range(15,30);
        }
    }
}
