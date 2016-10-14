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

    void Start()
    {
        SpawnOnce();
    }
    void Update()
    {
        if (_spawnable)
        {
            Spawn();
        }
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
        ObjectSpawner(Objects, spawnPoints);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Spawn_Object")
        {
            Spawn();
        }
    }
}
