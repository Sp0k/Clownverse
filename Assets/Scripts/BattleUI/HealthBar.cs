using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class  HealthBar : MonoBehaviour
{
    private static int health;
    private float yPos;
    private float xPos;

    
        
    // Start is called before the first frame update
    void Start()
    {
        health = 50;
    }

    // Update is called once per frame
    void Update()
    {
        yPos = transform.position.y;
        xPos = transform.position.x;
        if (health < 50) {
            transform.position = new Vector3( -(50-health), yPos, 0); 
        }

        else if (health > 50) {
            transform.position = new Vector3(50-health, yPos, 0);
        }
        else {
            transform.position = new Vector3(0, yPos, 0); 
        }
    }

    public int getHealth() { return health; }

    public static void affectHealth(int value)
    {
        health += value;
    }
}
