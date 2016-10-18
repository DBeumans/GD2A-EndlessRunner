using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Check_Player : MonoBehaviour {

    /*
        This script keeps track if the player is alive or dead.
    
    */
    Player_Health player_health;
    SaveBehaviour save_behaviour;

    void Start()
    {
        player_health = GameObject.FindObjectOfType<Player_Health>();
        save_behaviour = gameObject.GetComponent<SaveBehaviour>();
    }

    void Update()
    {
        CheckPlayerHealth();
        if (player_health.player_alive == false)
        {
            // dead
            print("dead");
            save_behaviour.SaveGame();
            SceneManager.LoadScene(2);
        }
    }

    void CheckPlayerHealth()
    {
        if (player_health.player_Health <= 0)
        {
            player_health.player_alive = false;
            //Destroy(this.gameObject);
        }
    }
}
