using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_setup_1 : MonoBehaviour
{
    // Class attributes
    private int good = -20;
    private int bad = 20;
    private int mediocre = 50;

    // Start is called before the first frame update
    void Start()
    {
        Joke[] jokes = new Joke[5];
        for (int i = 0; i < jokes.Length; i++)
        {
            jokes[i] = new Joke();
        }
        
        // First Joke
        // Punchlines
        Punchline[] punchlines = new Punchline[3];
        for (int i = 0; i < punchlines.Length; i++)
        {
            punchlines[i] = new Punchline();
        }
        punchlines[0].setValues("bad", bad, false);
        punchlines[1].setValues("good", good, true);
        punchlines[2].setValues("mediocre", mediocre, false);

        // Joke
        .setValues("Joke", punchlines);
    }
}
