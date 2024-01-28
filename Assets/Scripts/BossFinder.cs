using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class BossFinder : MonoBehaviour
{
    public Transform boss;
    public float triggerDist = 10f;

    public CinemachineVirtualCamera bossCam;
    public Canvas battleUI;

    private void Update()
    {
        float dist = Mathf.Sqrt(Mathf.Pow(boss.position.x - transform.position.x, 2) + Mathf.Pow(boss.position.y - transform.position.y, 2));

        if (dist < triggerDist)
        {
            // start boss battle
            
            if (Input.GetKeyDown(KeyCode.Return)) 
            {
                bossCam.Priority = 11;
                battleUI.gameObject.SetActive(true);
                // init battle scripts
                // turn off normal player scripts
            }
        }
    }
}
