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

    private TextMeshProUGUI text1;
    private TextMeshProUGUI text2;
    private TextMeshProUGUI text3;

    private Boss_setup_1 bs1;
    private int health;



    //public RunBattle(Joke[] jokes)
    //{
    //    this.jokes = jokes; 
    //    jokeIndex = 0;
    //}

    // Start is called before the first frame update
    void Start()
    {
        jokeIndex = 0;
        bs1 = new Boss_setup_1();
        jokes = bs1.getJokes();

        displayJoke();
    }

    // Update is called once per frame
    void Update()
    {
        //End conditions
        health = HealthBar.getHealth();
        if (JokeCounter > 4)
        {
            //Determine who wins
            if (health > 50)
            {
                //Player wins
            }
            else
            {
                //Player looses
            }
        }

        else if (health >= 100)
        {
            //player wins
        }
        else if (health <= 0) 
        {
            //player looses
        }
    }


    public void UpdateButtons() 
    { 
        
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

    //public static Joke GetActiveJoke() { return ActiveJoke;  }
}
