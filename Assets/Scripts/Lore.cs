using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lore : MonoBehaviour
{
    public List<string> text = new List<string>();
    [SerializeField] TextMeshProUGUI textBox;
    int textNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        text.Add("Welcome to Clown College, You have worked tirelessly to get here and are ready to begin your journey to become the Funniest Clown.");
        text.Add("But when you arrive things seem... off. An oddly unfunny haze has covered the campus, there is a dark hue to it.");
        text.Add("It seems that the professors of the prestigious Clown College have been corrupted by an entity known as the Void Clown.");
        text.Add("Their laugh-force is being siphoned to the anti-clown world. You remain uncorrupted and you need to purify them and restore their laughter.");
        text.Add("It is up to you to save clown society.");
        textBox.text = text[textNumber];
    }

    public void IncreaseText()
    {
        textNumber++;
        textBox.text = text[textNumber];
    }
    public void DecreaseText()
    {
        textNumber--;
        textBox.text = text[textNumber];
    }

    void Update()
    {
        
    }
}
