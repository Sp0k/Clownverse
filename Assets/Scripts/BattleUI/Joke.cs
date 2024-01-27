using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joke : MonoBehaviour
{
    private string jokeString; 
    private static bool isGood;
    private int damage; 


    public Joke(string jokeString, int damage)
    {
        this.jokeString = jokeString;
        this.damage = damage;
    }

    public static void EffectOnHealth()
    {
        if (isGood)
        {
            HealthBar.affectHealth(10);
        }
        else
        {
            HealthBar.affectHealth(-10);
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Joke getJoke() { return this; }



}
