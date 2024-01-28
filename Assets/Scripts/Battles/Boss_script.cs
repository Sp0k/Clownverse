using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class Boss_script
{
    public int _battleIndex;
    private Joke[] jokes = new Joke[5];


    public Boss_script(int _battleIndex)
    {
        switch (_battleIndex)
        {
            case 0:
                Boss_setup_1 bs1 = new Boss_setup_1();
                jokes = bs1.getJokes();
                break;
        }
    }

    public Joke[] getJokes() { return jokes; }
}
