using UnityEngine;
using System.Collections;

public class Pot_Color : ColorBehaviour {
    ColorBehaviour color = new ColorBehaviour();
    
    void Stard() {
        //sets the color of a pot
        color.setColor("pot", "#");
    }
}