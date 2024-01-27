using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using BattleUI/Button; 

public class battle1 : MonoBehaviour
{
    // Start is called before the first frame update

    public List<Joke> jokeList = new List<Joke>();

    public battle1() {
        Joke joke1 = new Joke("Joke1", 30);
        Joke joke2 = new Joke("Joke2", -20);
        Joke joke3 = new Joke("Joke3", 60);
        jokeList.Add(joke1);
        jokeList.Add(joke2);
        jokeList.Add(joke3);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
