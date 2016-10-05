using UnityEngine;
using System.Collections;

public class CheckSpawning : MonoBehaviour {

    House_Spawner _house_Spawner;
    Background_Spawner _background_Spawner;
    string _gameObject_Name;

    void Start()
    {
        _house_Spawner = GameObject.FindObjectOfType<House_Spawner>();
        _background_Spawner = GameObject.FindObjectOfType<Background_Spawner>();

        _gameObject_Name = this.gameObject.tag;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch(_gameObject_Name)
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
        }
    }
}
