using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Third fight. 
 * Dark Humor Fight. 
 * @Location: tbd
 */

public class Boss_setup_3
{
    // Class attributes
    private const int good = 10;
    private const int bad = -10;
    private const int mediocre = -15;

    private Joke[] jokes = new Joke[5];

    // Start is called before the first frame update
    public Boss_setup_3()
    {
        Punchline[] punchlines;

        // First Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("*Stares off blankly into space*", bad, false);
        punchlines[1] = new Punchline("I should really stop giving directions.", good, true);
        punchlines[2] = new Punchline(" I should really stop killing my friends.", mediocre, false);

        jokes[0] = new Joke(punchlines, "I Always feel bad when I remember the people I’ve lost.");

        // Second Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("Attempted a backflip.", mediocre, false);
        punchlines[1] = new Punchline("Coughed.", bad, false);
        punchlines[2] = new Punchline("Brought back his leg.", good, true);

        jokes[1] = new Joke(punchlines, "I’ll never forget the last thing my grandpa did before kicking the bucket.");

        // Third Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("But her aim keeps getting better.", good, true);
        punchlines[1] = new Punchline("Which is odd, since I never had one.", mediocre, false);
        punchlines[2] = new Punchline("I shouldn’t have ever left her.", bad, false);

        jokes[2] = new Joke(punchlines, "My ex wife still misses me");

        // Fourth Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("I am.", bad, false);
        punchlines[1] = new Punchline("I really wish my mom would stop saying that.", mediocre, false);
        punchlines[2] = new Punchline("At least I can be a bad example.", good, true);

        jokes[3] = new Joke(punchlines, "I’m always told I am good for nothing");

        // Fifth Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("Do you know where I can drop mine off?", good, true);
        punchlines[1] = new Punchline("I’m glad I’ve made up my mind.", bad, false);
        punchlines[2] = new Punchline("I should probably tell them.", mediocre, false);

        jokes[4] = new Joke(punchlines, "I always thought I wanted kids, I don’t think I do anymore.");
    }

    public Joke[] getJokes() { return jokes; }
}
