using UnityEngine;
using System.Collections;

public class Objects_Spawner : SpawningBehaviour {

    //Object to spawn , its a array so you can spawn different objects of the same type.
    [SerializeField]
    GameObject[] Objects;
    //Spawnpoints, where the objects needs to spawn.
    [SerializeField]
    Transform spawnPoints;
    public bool _spawnable = false;
    [SerializeField]
    Transform[] spawnPointOneTime;
    float spawnTime = 2f;

    void Start()
    {
        SpawnOnce();
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }
    
    void SpawnOnce()
    {
        for (int i = 0; i < spawnPointOneTime.Length; i++)
        {
            ObjectSpawner(Objects, spawnPointOneTime[i]);
        }
    }

    void Spawn()
    {
        _spawnable = false;
        Debug.Log("Spawned a object");
        ObjectSpawner(Objects, spawnPoints);
    }
}
