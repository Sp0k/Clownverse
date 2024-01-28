using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorruptionManager : MonoBehaviour
{
    
    public List<List<Material>> buildings;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            if (!WorldSave.bossWins[i]) continue;
            var bossBuildings = buildings[i];
            foreach(var building in bossBuildings)
            {
                building.SetFloat("Corruption Level",0);
            }
        }
    }
}
