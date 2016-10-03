using UnityEngine;
using System.Collections;

public class House_Spawner_One_Time : SpawningBehaviour {

    // storage voor houses
    // random house pakken 
    // spawnen

    [SerializeField]
    GameObject[] Houses;

    [SerializeField]
    Transform[] spawnPoint_1;
    [SerializeField]
    Transform[] spawnPoint_2;

    void Start()
    {
        ObjectSpawner(Houses, spawnPoint_1);
        ObjectSpawner(Houses, spawnPoint_2);
    }
}
