using UnityEngine;
using System.Collections;

public class House_Spawner : MonoBehaviour {

    [SerializeField]
    GameObject House;            
    [SerializeField]    
    float spawnTime = 1f;   
    [SerializeField]        
    Transform[] spawnPoints;         


    void Start()
    {
        
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
       
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        
        Instantiate(House, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }


}
