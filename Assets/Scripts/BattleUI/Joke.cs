using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joke : MonoBehaviour
{
    private string jokeString; 
    private bool isGood;
    private int damage; 


    public Joke(string jokeString, bool isGood, int damage)
    {
        this.jokeString = jokeString;
        this.isGood = isGood;
        this.damage = damage;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
