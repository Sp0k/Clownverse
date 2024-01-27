using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonSelect : MonoBehaviour
{
    public GameObject firstButton;
    [Range(0.01f, 1)]
    public float speed;

    Vector3 targetPos;

    private void Start()
    {
        EventSystem.current.SetSelectedGameObject(firstButton, new BaseEventData(EventSystem.current));
    }

    void Update()
    {
        Vector3 buttonPos = EventSystem.current.currentSelectedGameObject.transform.position;

        float x = (buttonPos.x - transform.position.x) * speed;
        float y = (buttonPos.y - transform.position.y) * speed;

        transform.position = new Vector3(transform.position.x + x, transform.position.y + y, 0);
    }
}
