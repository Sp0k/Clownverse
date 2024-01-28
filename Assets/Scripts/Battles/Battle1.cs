using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * First Battle. 
 * 
 * JokeList is the Array of an array of "Joke" Objects.
 * Each Joke object contains three "punchline" objects. 
 * 
 * 
 * punchline#S --> Good joke
 * punchline#B --> Bad Joke
 * punchline#RB --> Really bad joke
 * 
 */



public class Battle1 : MonoBehaviour
{
    
    // Array of Jokes
    public static Joke[] jokeList;



    void Start()
    {
        Joke joke1S = new Joke("Good Joke!", -20);
        Joke joke2B = new Joke("Bad Joke", 20);
        Joke joke3RB = new Joke("Really bad joke", 70);

        Joke[] punchlines1 = { joke1S, joke2B, joke3RB };

        Joke[][] jokeList = { punchlines1 }; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
