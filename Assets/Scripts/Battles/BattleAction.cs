//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.EventSystems;
//using UnityEngine.UI;

//public class BattleAction : MonoBehaviour
//{
//    public GameObject _button1; 
//    public GameObject _button2;


//    private Joke[] jokeList; // The Joke List to activaly display. 
//    private int jokeListIndex; // Can randomize this after to get random list of jokes. 
    

//    void Start()
//    {
        
//        EventSystem.current.SetSelectedGameObject(_button1, new BaseEventData(EventSystem.current));
//        jokeListIndex = 0;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (EventSystem.current.currentSelectedGameObject == _button2) 
//        {
            
//        }
//    }

//    /*
//     * Get new cycle of jokes and display.
//     */
//    void refreshJokeOptions() 
//    {
//        System.Random random = new System.Random();
//        this.jokeListIndex = random.Next(0, this.jokeList.Length);
//        this.jokeList = Battle1.jokeList[jokeListIndex]; // Grabbing joke list from the master joke list. 
        
//    }


//    public void _JokeOnClick() 
//    {
//        HealthBar.affectHealth(ButtonSelect.joke.getDamage()); 
//    }
//}
