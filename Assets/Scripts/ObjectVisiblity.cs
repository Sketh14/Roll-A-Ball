using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectVisiblity : MonoBehaviour
{
    public GameObject GameplayObjectVisible;
    private Renderer[] rend;
    private Rigidbody rb;
    public GameObject player;

    private void Start()
    {
        rend = GameplayObjectVisible.GetComponentsInChildren<MeshRenderer>();
        rb = player.GetComponent<Rigidbody>();
    }

    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            foreach (var ob in rend)
            {
                ob.enabled = false;
            }
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            rb.AddForce(movement * 10);
        }
    }

    public void OnTriggerExit()
    {
        foreach (var ob in rend)
        {
            ob.enabled = true;
        }
    }
}
