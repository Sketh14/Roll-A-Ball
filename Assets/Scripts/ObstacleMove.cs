using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public float jumpheight;

    public GameObject trig1;
    public Rigidbody player;
    
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }
    
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Jumping"))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Debug.Log("Key Pressed");
                player.AddForce(0, jumpheight*5, 0);
            }
        }
    }
}
