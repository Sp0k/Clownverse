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

    public Slider healthSlider;

    
        
    // Start is called before the first frame update
    void Start()
    {
        healthSlider.value = 50;
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = health;
    }

    public int getHealth() { return health; }

    public static void affectHealth(int value)
    {
        health += value;
    }
}
