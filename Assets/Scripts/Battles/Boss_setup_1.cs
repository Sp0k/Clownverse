using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_setup_1 : MonoBehaviour
{
    // Class attributes
    private int good = -20;
    private int bad = 20;
    private int mediocre = 50;

    private Joke[] jokes = new Joke[5];

    // Start is called before the first frame update
    void Start()
    {
        Punchline[] punchlines;

        // First Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("bad 1", bad, false);
        punchlines[1]= new Punchline ("good 1", good, true);
        punchlines[2]= new Punchline("mediocre 1", mediocre, false);

        jokes[0] = new Joke(punchlines, "Joke 1");

        // Second Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("mediocre 2", mediocre, false);
        punchlines[1] = new Punchline("bad 2", bad, false);
        punchlines[2] = new Punchline("good 2", good, true);

        jokes[1] = new Joke(punchlines, "Joke 2");

        // Third Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("good 3", good, true);
        punchlines[1] = new Punchline("mediocre 3", mediocre, false);
        punchlines[2] = new Punchline("bad 3", bad, false);

        jokes[2] = new Joke(punchlines, "Joke 3");

        // Fourth Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("bad 4", bad, false);
        punchlines[1] = new Punchline("mediocre 4", mediocre, false);
        punchlines[2] = new Punchline("good ", good, true);

        jokes[3] = new Joke(punchlines, "Joke 4");

        // Fifth Joke
        punchlines = new Punchline[3];
        punchlines[0] = new Punchline("good 5", good, true);
        punchlines[1] = new Punchline("bad 5", bad, false);
        punchlines[1] = new Punchline("mediocre 5", mediocre, false);
    }

    public Joke[] getJokes() { return jokes; }
}
