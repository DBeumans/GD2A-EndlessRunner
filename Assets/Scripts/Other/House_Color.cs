using UnityEngine;
using System.Collections;

public class House_Color : ColorBehaviour {
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            Player_Color player = gameObject.GetComponent<Player_Color>();
            //call the color function to set color
            base.setColor("house", player.getColor());
        }
    }
}