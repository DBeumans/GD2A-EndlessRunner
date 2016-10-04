using UnityEngine;
using System.Collections;

public class House_Spawner : SpawningBehaviour
{
    //Object to spawn , its a array so you can spawn different objects of the same type.
    [SerializeField]
    GameObject[] Houses;
    //Spawnpoints, where the objects needs to spawn.
    [SerializeField]        
    Transform[] spawnPoints;
    public bool _spawnable = false;


    /*

        Object mag pas spawnen wanneer de object ervoor over de spawn trigger point is gegaan.
        houses moeten een collision hebben om te checken of het eroverheen is of niet.

    */

    void Update()
    {
        /*
        spawnTime += Time.deltaTime;
        if (spawnTime >=5.0f)
        {
            spawnTime = 0f;
            Spawn();
        }
        */
        if(_spawnable)
        {
            Spawn();
        }
    }
    
    void Spawn()
    {
        _spawnable = false;
        ObjectSpawner(Houses, spawnPoints);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Spawn_House")
        {
            Spawn();
        }
    }
}
