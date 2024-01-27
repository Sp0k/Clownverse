using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonSelect : MonoBehaviour
{
    public GameObject firstButton;

    private void Start()
    {
        EventSystem.current.SetSelectedGameObject(firstButton, new BaseEventData(EventSystem.current));
    }

    void Update()
    {
        Vector3 buttonPos = EventSystem.current.currentSelectedGameObject.transform.position;

        transform.position = new Vector3(buttonPos.x, buttonPos.y, buttonPos.z);
    }
}
