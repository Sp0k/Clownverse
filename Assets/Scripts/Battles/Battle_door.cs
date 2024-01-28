using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Battle_door : MonoBehaviour
{
    // Class attributes
    public GameObject _player;
    public GameObject _uiObject;
    public string _sceneName;

    private bool doorReady = false;

    void Start()
    {
        _uiObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // scene transition
        if (doorReady && Input.GetKeyDown(KeyCode.E))
        {
            _uiObject.SetActive(false);
            SceneManager.LoadScene("Scenes/" + _sceneName, LoadSceneMode.Additive);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _uiObject.SetActive(true);
            doorReady = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _uiObject.SetActive(false);
        doorReady = false;
    }

}
