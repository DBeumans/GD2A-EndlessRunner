using UnityEngine;
using System.Collections;

public class CheckSpawning : MonoBehaviour {

    House_Spawner _house_Spawner;
    Background_Spawner _background_Spawner;
    Objects_Spawner _object_Spawner;
    string _gameObject_Name_Tag;

    void Start()
    {
        _house_Spawner = GameObject.FindObjectOfType<House_Spawner>();
        _background_Spawner = GameObject.FindObjectOfType<Background_Spawner>();
        _object_Spawner = GameObject.FindObjectOfType<Objects_Spawner>();

        _gameObject_Name_Tag = this.gameObject.tag;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch(_gameObject_Name_Tag)
        {
            case "Background_Trigger":
                if (other.gameObject.tag == "Spawn_Background")
                {
                    _background_Spawner._spawnable = true;
                }
                break;

            case "House_Trigger":
                if (other.gameObject.tag == "Spawn_House")
                {
                    _house_Spawner._spawnable = true;
                }
                break;
            case "Object_Trigger":
                if(other.gameObject.tag == "Spawn_Object")
                {
                    _object_Spawner._spawnable = true;   
                }
                break;
        }
    }
}
