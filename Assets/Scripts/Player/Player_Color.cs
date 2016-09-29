using UnityEngine;
using System.Collections;

public class Player_Color : ColorBehaviour {

    ColorBehaviour color = new ColorBehaviour();
    Pot_Color pot = new Pot_Color();
    void OnCollisionEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Pot") {
            //call the color function to set color
            color.setColor("normal", pot.getColor());
        }
        if (other.gameObject.tag == "Rain") {
            color.setColor("rain", color.getColor());
        }
        if (other.gameObject.tag == "Sun") {
            color.setColor("sun", color.getColor());
        }        
    }
}