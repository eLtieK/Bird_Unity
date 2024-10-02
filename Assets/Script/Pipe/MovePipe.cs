using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    private bool open = false;
    public GameObject Pipe;
    private float limit = 10.1f;
    public float deltaMove = 0;
    void Update()
    {
        if(open == true && deltaMove <= limit) 
        {
            deltaMove += Time.deltaTime*10;
            if (Pipe.name == "Bottom Pipe") { Pipe.transform.position += Vector3.down * Time.deltaTime * 10; }
            else if(Pipe.name == "Top Pipe") { Pipe.transform.position += Vector3.up * Time.deltaTime * 10; }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Missile") { open = true; }
    }
}
