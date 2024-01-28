using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joke : MonoBehaviour
{
    private Punchline[] punchlineArr; 
    private string setup; 


    public Joke(Punchline[] punchlineArr, string setup)
    {
        this.punchlineArr = punchlineArr;
        this.setup = setup;        
    }




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Punchline[] GetPunchlineArr() { return this.punchlineArr; }
    public string GetSetup() { return this.setup;}



}
