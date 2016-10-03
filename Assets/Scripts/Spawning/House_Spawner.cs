﻿using UnityEngine;
using System.Collections;

public class House_Spawner : SpawningBehaviour
{
    //Object to spawn , its a array so you can spawn different objects of the same type.
    [SerializeField]
    GameObject[] Houses;
    //Spawn timer, change the spawn timer to spawn objects faster or slower.
    [SerializeField]
    float spawnTime = 0f;
    //Spawnpoints, where the objects needs to spawn.
    [SerializeField]        
    Transform[] spawnPoints;


    /*

        Object mag pas spawnen wanneer de object ervoor over de spawn trigger point is gegaan.
        houses moeten een collision hebben om te checken of het eroverheen is of niet.

    */

    void Update()
    {
        spawnTime += Time.deltaTime;
        if (spawnTime >=5.0f)
        {
            spawnTime = 0f;
            Spawn();
        }
    }

    void Spawn()
    {
        ObjectSpawner(Houses, spawnPoints);
    }
}
