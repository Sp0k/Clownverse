using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class  HealthBar : MonoBehaviour
{
    public static int health;
    private float yPos;
    private float xPos;

    public Slider healthSlider;

    
        
    // Start is called before the first frame update
    void Start()
    {
        //Default value is always 50. 
        health = 50;
        healthSlider.value = (float)health/100;
    }

    // Update is called once per frame
    void Update()
    {
        if (health >= 100)
        {
            healthSlider.value = (float)1;
        }
        else if (health <= 0) {
            healthSlider.value = (float)0;
        }
        else
        {
            healthSlider.value = (float)health/100;
        }
    }

    public static int getHealth() { return health; }

    public static void affectHealth(int value)
    {
        if (health + value <= 100 || health + value >= 0)
        {
            health += value;
        } 
        else if (health + value < 0)
        {
            health = 0;
        }
        else
        {
            health = 100;
        }
    }
}
