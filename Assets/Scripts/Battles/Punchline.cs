using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punchline : MonoBehaviour
{
    // Class attributes
    private string text;
    private int value;
    private bool good;

    // Setter
    public void setValues(string text, int value, bool good)
    {
        this.text = text;
        this.value = value;
        this.good = good;
    }

    // Getters
    public string getText() { return text; }
    public int getValue() { return value; }
    public bool getGood() { return good; }  
}
