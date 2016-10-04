using UnityEngine;
using System.Collections;

public class CheckSpawning : MonoBehaviour {

    House_Spawner _house_Spawner;

    void Start()
    {
        _house_Spawner = GameObject.FindObjectOfType<House_Spawner>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Spawn_House")
        {
            _house_Spawner._spawnable = true;
            
        }
    }

}
