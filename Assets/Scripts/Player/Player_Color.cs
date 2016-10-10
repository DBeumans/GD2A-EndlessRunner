using UnityEngine;
using System.Collections;

public class Player_Color : ColorBehaviour {
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Pot" ||
         other.gameObject.tag == "Crate" ||
         other.gameObject.tag == "Tube") {
            string pot = this.gameObject.GetComponent<Pot_Color>().getColor();
            //call the color function to set color
            base.setColor("normal", pot);
            Debug.Log("Error Player_Color Pots");
        }
        if (other.gameObject.tag == "Rain") {
            base.setColor("rain", base.getColor());
            Debug.Log("Error Player_Color rain");
        }
        if (other.gameObject.tag == "Sun") {
            base.setColor("sun", base.getColor());
            Debug.Log("Error Player_Color sun");
        }
    }
}