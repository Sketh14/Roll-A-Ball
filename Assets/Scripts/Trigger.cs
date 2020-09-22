using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject trigger;
    public GameObject path;
    void Update ()
    {

        if (!trigger.activeInHierarchy)
        {
            print("Path Enabled");
            path.SetActive(true);
        }
    }
}
