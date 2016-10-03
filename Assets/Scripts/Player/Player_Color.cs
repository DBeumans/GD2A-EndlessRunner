using UnityEngine;
using System.Collections;

public class Player_Color : ColorBehaviour {
    private void OnCollisionEnter2D(Collision2D other) {

        

        if (other.gameObject.tag == "Pot" ||
         other.gameObject.tag == "Crate" ||
         other.gameObject.tag == "Tube") {
            string pot = other.gameObject.GetComponent<Pot_Color>().getColor();
            //call the color function to set color
            base.setColor("normal", pot);
        }
        if (other.gameObject.tag == "Rain") {
            base.setColor("rain", base.getColor());
        }
        if (other.gameObject.tag == "Sun") {
            base.setColor("sun", base.getColor());
        }
    }
}