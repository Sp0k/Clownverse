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
    private Joke ActiveJoke;
    private int jokeIndex;

    //Attack Options. 
    public GameObject _button1; 
    public GameObject _button2;
    public GameObject _button3;

    private TextMeshProUGUI text1;
    private TextMeshProUGUI text2;
    private TextMeshProUGUI text3;



    public RunBattle(Joke[] jokes)
    {
        this.jokes = jokes; 
        jokeIndex = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.ActiveJoke = jokes[0];
        _button1 = GameObject.Find("Joke1");
        _button2 = GameObject.Find("Joke2");
        _button3 = GameObject.Find("Joke 3");
        
    }

    // Update is called once per frame
    void Update()
    {
        //End conditions
        int health = HealthBar.getHealth();
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
    public void _JokeOnClick()
    {
        if (EventSystem.current.currentSelectedGameObject == _button1)
        {
            HealthBar.affectHealth(this.ActiveJoke.GetPunchlineArr()[0].getValue());
        }
        else if (EventSystem.current.currentSelectedGameObject == _button2) 
        {
            HealthBar.affectHealth(this.ActiveJoke.GetPunchlineArr()[1].getValue()); 
        }
        else
        {
            HealthBar.affectHealth(this.ActiveJoke.GetPunchlineArr()[2].getValue());
        }
        
    }

    //public static Joke GetActiveJoke() { return ActiveJoke;  }
}
