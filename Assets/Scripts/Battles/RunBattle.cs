using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI; 

public class RunBattle : MonoBehaviour
{

    private int JokeCounter = 0; 

    private Joke[] jokes;
    private Joke activeJoke;
    private int jokeIndex;

    //Attack Options. 
    public GameObject _setupScript;
    public GameObject _joke;
    public GameObject _button1; 
    public GameObject _button2;
    public GameObject _button3;
    public TextMeshProUGUI _winLose;

    private TextMeshProUGUI text1;
    private TextMeshProUGUI text2;
    private TextMeshProUGUI text3;

    public int _battleIndex;
    private Boss_script bs;
    private int health;



    // Start is called before the first frame update
    void Start()
    {
        jokeIndex = 0;
        bs = new Boss_script(_battleIndex);
        jokes = bs.getJokes();

        _winLose.gameObject.SetActive(false);

        displayJoke();
    }

    public void endBattle()
    {
        health = HealthBar.getHealth();
        // Win/Lose screen
        _winLose.gameObject.SetActive(true);
        if (health >= 50)
        {
            _winLose.text = "YOU WIN!!! :)";
        }
        else
        {
            _winLose.text = "YOU LOSE!!! :)";
        }

        // switch back
    }

    public void endTurn(int index)
    {
        Punchline chosen = activeJoke.GetPunchlineArr()[index];
        HealthBar.affectHealth(chosen.getValue());

        if (chosen.getGood() == true)
        {
            // Play happy sounds
        }
        else
        {
            // play sad sounds
        }

        jokeIndex++;

        if (jokeIndex < 5)
        {
            displayJoke();
        }
        else
        {
            endBattle();
        }
    }

    public void displayJoke()
    {
        // Setup
        activeJoke = jokes[jokeIndex];
        _joke.GetComponent<TextMeshProUGUI>().text = activeJoke.GetSetup();

        // Punclines
        _button1.GetComponentInChildren<TextMeshProUGUI>().text = "1. " + activeJoke.GetPunchlineArr()[0].getText();
        _button2.GetComponentInChildren<TextMeshProUGUI>().text = "2. " + activeJoke.GetPunchlineArr()[1].getText();
        _button3.GetComponentInChildren<TextMeshProUGUI>().text = "3. " + activeJoke.GetPunchlineArr()[2].getText();
    }
}
