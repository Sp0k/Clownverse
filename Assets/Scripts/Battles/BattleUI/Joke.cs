using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joke : MonoBehaviour
{
    private Punchline[] punchlineArr; 
    private string setup; 


    public Joke(string punchlineStr, int damage)
    {
        this.punchlineStr = punchlineStr;
        this.damage = damage;
        if (this.damage > 0) { 
            this.isGood = true; 
        }
        else
        {
            this.isGood = false;
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

    public string getPunchlineString() { return this.jokeString; }
    public int getPunchlineDamage() { return this.damage; }



}
