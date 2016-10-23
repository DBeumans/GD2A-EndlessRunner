using UnityEngine;
using System.Collections;

public class Player_Health : MonoBehaviour {

    public int player_Health;
    public bool player_alive;

    void Start()
    {
        player_Health = 100;
        player_alive = true;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Death")
        {
            player_Health -= 100;
        }
        
    }
}
