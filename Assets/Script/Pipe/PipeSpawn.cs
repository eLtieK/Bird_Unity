using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;
    public float speedHarder = 0.1f;
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if(transform.position.x < deadZone) 
        { 
            Debug.Log("Pipe Deleted");
            Destroy(gameObject); 
        }
    }
}
