using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crowd_behavior : MonoBehaviour
{
    private float expectedTime;
    private float randomTime;
    [SerializeField] private Animation _animation;

    // Start is called before the first frame update
    void Start()
    {
        randomTime = Random.Range(0.5f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (expectedTime < Time.deltaTime) 
        {
            _animation.Play();
            setLoop();
        }
    }

    void setLoop()
    {
        randomTime = Random.Range(0.5f, 10.0f);
        expectedTime = Time.time + randomTime;
    }
}
