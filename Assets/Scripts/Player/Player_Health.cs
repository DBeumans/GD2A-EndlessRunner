using UnityEngine;
using System.Collections;

public class Player_Health : MonoBehaviour {

    public int player_Health;

    void Start()
    {
        player_Health = 100;
    }
    void Update()
    {
        if(player_Health <= 0 )
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Death")
        {
            player_Health -= 100;
            Destroy(gameObject);
        }
    }
}
