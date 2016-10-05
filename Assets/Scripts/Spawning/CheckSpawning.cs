using UnityEngine;
using System.Collections;

public class CheckSpawning : MonoBehaviour {

    House_Spawner _house_Spawner;
    Background_Spawner _background_Spawner;

    void Start()
    {
        _house_Spawner = GameObject.FindObjectOfType<House_Spawner>();
        _background_Spawner = GameObject.FindObjectOfType<Background_Spawner>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Spawn_House")
        {
            _house_Spawner._spawnable = true;
            
        }
        if(other.gameObject.tag == "Spawn_Background")
        {
            _background_Spawner._spawnable = true;
        }
    }

}
