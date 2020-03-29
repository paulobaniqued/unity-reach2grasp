using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public Rigidbody trialObject;
    public Transform spawnpoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Debug.Log("1 pressed");

            Rigidbody clone;

            clone = Instantiate(trialObject, spawnpoint.position, spawnpoint.rotation)as Rigidbody;
        }
        
    }
}
