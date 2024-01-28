using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Second fight. 
 * Insult Comedy Fight 
 * @Location: tbd
 */

public class Boss_setup_2
{
    // Class attributes
    private const int good = 10;
    private const int bad = -10;
    private const int mediocre = -15;

    private Joke[] jokes = new Joke[5];

    // Start is called before the first frame update
    public Boss_setup_2()
    {
        Punchline[] punchlines;

        // First Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("*Start Crying*", bad, false);
        punchlines[1] = new Punchline("I thought clowns all wore makeup, but that’s just your face.", good, true);
        punchlines[2] = new Punchline("Hey, that’s really mean I have a lot of student debt.", mediocre, false);

        jokes[0] = new Joke(punchlines, "You came for clown college but you’re just a waste");

        // Second Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("I can tell by your students, they wish they hadn’t.", mediocre, false);
        punchlines[1] = new Punchline("Why? Is it because I can’t read?", bad, false);
        punchlines[2] = new Punchline("I’m glad I’ve never been to your class, I’d hate to be taught by a ghoul.", good, true);

        jokes[1] = new Joke(punchlines, "I can tell by your jokes, you haven’t started school");

        // Third Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("I don’t really care, I don’t take feedback from dirt.", good, true);
        punchlines[1] = new Punchline("I can imagine, I don’t think you could tell if it was good or bad .", mediocre, false);
        punchlines[2] = new Punchline("Well… It should have.", bad, false);

        jokes[2] = new Joke(punchlines, "Just so you know that insult didn’t hurt.");

        // Fourth Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("What are you gonna do? Cry?", bad, false);
        punchlines[1] = new Punchline("Funny, your ex-wife said the same thing.", mediocre, false);
        punchlines[2] = new Punchline("Not yet, I’ll insult you so well your relatives will grieve.\r\n", good, true);

        jokes[3] = new Joke(punchlines, "Just leave!");

        // Fifth Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("I can tell by the look in your eyes, this insult fight will be your demise.", good, true);
        punchlines[1] = new Punchline("...", bad, false);
        punchlines[2] = new Punchline("At a loss for words? Seems common for you.\r\n", mediocre, false);

        jokes[4] = new Joke(punchlines, "...");
    }

    public Joke[] getJokes() { return jokes; }
}
