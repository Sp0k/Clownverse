using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Dad Jokes Fight
 * @Location: Dadplex
 */

public class Boss_setup_1
{
    // Class attributes
    private const int good = 10;
    private const int bad = -10;
    private const int mediocre = -15;

    private Joke[] jokes = new Joke[5];

    // Start is called before the first frame update
    public Boss_setup_1()
    {
        Punchline[] punchlines;

        // First Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("Send it to dance class", bad, false);
        punchlines[1]= new Punchline ("Put a little boogie in it.", good, true);
        punchlines[2]= new Punchline("Threaten it with a machine gun", mediocre, false);

        jokes[0] = new Joke(punchlines, "How do you make a tissue dance?");

        // Second Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("Data", mediocre, false);
        punchlines[1] = new Punchline("Father", bad, false);
        punchlines[2] = new Punchline("Computers don't have parents", good, true);

        jokes[1] = new Joke(punchlines, "What does a baby computer call its father?");

        // Third Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("The rest are weekdays!", good, true);
        punchlines[1] = new Punchline("Because they are my days off", mediocre, false);
        punchlines[2] = new Punchline("The historical context", bad, false);

        jokes[2] = new Joke(punchlines, "Why are Saturday and Sunday the strongest days?");

        // Fourth Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("Cows don’t know what’s happening", bad, false);
        punchlines[1] = new Punchline("Udder cows", mediocre, false);
        punchlines[2] = new Punchline("They read the Moospaper", good, true);

        jokes[3] = new Joke(punchlines, "Why didn’t the banana go to jail after robbing a bank?");

        // Fifth Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("It got off on appeal!", good, true);
        punchlines[1] = new Punchline("A banana can’t rob a bank", bad, false);
        punchlines[2] = new Punchline("Bribed the police", mediocre, false);
        
        jokes[4] = new Joke(punchlines, "Why didn’t the banana go to jail after robbing a bank?");
    }

    public Joke[] getJokes() { return jokes; }
}
