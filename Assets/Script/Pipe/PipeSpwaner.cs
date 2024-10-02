using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PipeSpwaner : MonoBehaviour
{
    public GameObject pipe;
    public PipeSpawn pipeLogic;
    public GameObject targetPipe;
    public PipeSpawn targetPipeLogic;
    public GameObject targetPipeTop;
    public PipeSpawn targetPipeTopLogic;
    public HealthSpawner healthSpawner;
    public float SpawnRate = 8;
    private float timer = 0;
    public float heightOffSetTop = 8;
    public float heightOffSetBottom = 4.5f;
    // Start is called before the first frame update
    void SpawnPipe() 
    {
        float lowestPoint = transform.position.y - heightOffSetBottom;
        float highestPoint = transform.position.y + heightOffSetTop;
        if (SceneManager.GetActiveScene().name == "HardMode")
        {
            if (Random.Range(0, 3) == 1) { Instantiate(targetPipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation); }
            else if (Random.Range(0, 3) == 0) { Instantiate(targetPipeTop, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation); }
            else { Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation); }
        }
        else { Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation); }
    }
    void Start()
    {
        pipeLogic.moveSpeed = 5;
        if(SceneManager.GetActiveScene().name == "HardMode")
        { 
            SpawnRate = 8; 
            targetPipeLogic = targetPipe.GetComponent<PipeSpawn>(); 
            targetPipeLogic.moveSpeed = 5;
            targetPipeTopLogic = targetPipeTop.GetComponent<PipeSpawn>();
            targetPipeTopLogic.moveSpeed = 5;
        }
        else { SpawnRate = 6; }
        SpawnPipe();
        pipeLogic = pipe.GetComponent<PipeSpawn>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate) { timer += Time.deltaTime; }
        else {
            SpawnPipe(); 
            timer = 0;
            if (pipeLogic.moveSpeed >= 10) { pipeLogic.moveSpeed = 10; }
            else { pipeLogic.moveSpeed += pipeLogic.speedHarder; }
           
            healthSpawner.heartLogic.moveSpeed = pipeLogic.moveSpeed;
            if (SceneManager.GetActiveScene().name == "HardMode") 
            { 
                targetPipeLogic.moveSpeed = pipeLogic.moveSpeed;
                targetPipeTopLogic.moveSpeed = pipeLogic.moveSpeed;
            }

            if (SpawnRate <= 3 && SceneManager.GetActiveScene().name == "PlayScreen") { SpawnRate = 3; }
            else if (SpawnRate <= 4 && SceneManager.GetActiveScene().name == "HardMode") { SpawnRate = 4; }
            else { SpawnRate -= pipeLogic.speedHarder; }
        }

    }
}
