using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCameraTracker : MonoBehaviour
{
    public Transform player;
    public Transform boss;

    private void Update()
    {
        Vector3 playerPos = player.position;
        Vector3 bossPos = boss.position;

        float midX = (playerPos.x + bossPos.x) / 2;
        float midY = (playerPos.y + bossPos.y) / 2;
        float midZ = (playerPos.z + bossPos.z) / 2;

        transform.position = new Vector3(midX, midY, midZ);
    }
}
