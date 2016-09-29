using UnityEngine;
using System.Collections;

public class House_Color : ColorBehaviour {

    ColorBehaviour color = new ColorBehaviour();
    Player_Color player = new Player_Color();
    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            //call the color function to set color
            color.setColor("house", player.getColor());
        }
    }
}