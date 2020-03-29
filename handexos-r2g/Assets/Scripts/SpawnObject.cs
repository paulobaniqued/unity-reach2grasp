using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public Rigidbody trialObject1;
    public Rigidbody trialObject2;
    public Rigidbody trialObject3;
    public Transform spawnpoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Debug.Log("1 pressed");

            Rigidbody clone1;
            clone1 = Instantiate(trialObject1, spawnpoint.position, spawnpoint.rotation)as Rigidbody;
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Debug.Log("2 pressed");

            Rigidbody clone2;
            clone2 = Instantiate(trialObject2, spawnpoint.position, spawnpoint.rotation)as Rigidbody;
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            Debug.Log("3 pressed");

            Rigidbody clone3;
            clone3 = Instantiate(trialObject3, spawnpoint.position, spawnpoint.rotation)as Rigidbody;
        }
        
    }
}
