using UnityEngine;
using System.Collections;

public class Background_Spawner : SpawningBehaviour {

    //Object to spawn , its a array so you can spawn different objects of the same type.
    [SerializeField]
    GameObject[] Backgrounds;
    //Spawnpoints, where the objects needs to spawn.
    [SerializeField]
    Transform spawnPoints;
    public bool _spawnable = false;

    void Start()
    {
        Spawn();
    }
    void Update()
    {
        if(_spawnable)
        {
            Spawn();
        }
    }
    
    void Spawn()
    {
        _spawnable = false;
        ObjectSpawner(Backgrounds, spawnPoints);
    }
}
