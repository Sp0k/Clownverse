using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarHandle : MonoBehaviour
{

    private int health;
    private float yPos;
    private float xPos;

    // Start is called before the first frame update
    void Start()
    {
        // This needs to be retrieved from some game value 
        health = 50; 
    }

    // Update is called once per frame
    void Update()
    {
        if (health < 50)
        {
            transform.position = new Vector3(-(50 - health), yPos, 0);
        }

        else if (health > 50)
        {
            transform.position = new Vector3(50 - health, yPos, 0);
        }
        else
        {
            transform.position = new Vector3(0, yPos, 0);
        }
    }
}
