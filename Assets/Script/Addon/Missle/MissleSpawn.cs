using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleSpawn : MonoBehaviour
{
    public int shootSpeed = 8;
    public int deadZone = 45;
    void Update()
    {
        transform.position = transform.position + (Vector3.right * shootSpeed) * Time.deltaTime;
        if (transform.position.x > deadZone)
        {
            Debug.Log("Missle Deleted");
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pipe") 
        {
            Debug.Log("Exploded");
            Destroy(gameObject);
        }
    }
}
