using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonSelect : MonoBehaviour
{
    public Slider slider;
    public Image image;
    public GameObject firstButton;
    [Range(0.01f, 1)]
    public float speed;
    public static Joke joke; 

    GameObject lastSelectedButton;


    private void Start()
    {
        slider.interactable = false;
        image = GetComponent<Image>();
        image.enabled = true;
        EventSystem.current.SetSelectedGameObject(firstButton, new BaseEventData(EventSystem.current));
        lastSelectedButton = firstButton;
    }

    void Update()
    {
        if (EventSystem.current.currentSelectedGameObject == null || EventSystem.current.currentSelectedGameObject.GetComponent<Button>() == null) 
        {
            EventSystem.current.SetSelectedGameObject(lastSelectedButton, new BaseEventData(EventSystem.current));
        }

        Vector3 buttonPos = EventSystem.current.currentSelectedGameObject.transform.position;

        float x = (buttonPos.x - transform.position.x) * speed;
        float y = (buttonPos.y - transform.position.y) * speed;

        transform.position = new Vector3(transform.position.x + x, transform.position.y + y, 0);
        
    }
}
