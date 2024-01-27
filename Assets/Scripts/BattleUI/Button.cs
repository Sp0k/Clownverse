using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;



public class Button : MonoBehaviour
{

    public TextMeshProUGUI Text;

    private Joke joke;

    public Button(List<Joke> jokeList)
    {
        int jokeIndex = Random.Range(0, jokeList.Count);
        this.joke = jokeList.ElementAt(jokeIndex);
        jokeList.RemoveAt(jokeIndex);
     
    }

    // Start is called before the first frame update
    void Start()
    {
        Text = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = joke.getJokeString();
    }

    public void jokeClicked() {
        //affectHealth(get)
    }


}
