﻿using UnityEngine;
using System.Collections;

public class House_Spawner : SpawningBehaviour
{
    //Object to spawn , its a array so you can spawn different objects of the same type.
    [SerializeField]
    GameObject[] Houses;
    //Spawn timer, change the spawn timer to spawn objects faster or slower.
    [SerializeField]
    float spawnTime = 1f;
    //Spawnpoints, where the objects needs to spawn.
    [SerializeField]        
    Transform[] spawnPoints;         

    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }
    void Spawn()
    {
        ObjectSpawner(Houses, spawnPoints);
    }
}
