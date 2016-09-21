using UnityEngine;
using System.Collections;

public class InputBehaviour : ControllsStatement {

    //Keyboard bool variables
    public bool forward = false;
    public bool rightRo = false;
    public bool leftRo = false;
    public bool right = false;
    public bool left = false;
    public bool jump = false;

    //Controller bool variables
    public bool controller_jump = false;

    //Keyboard keycode variables
    public KeyCode Forward;
    public KeyCode RightRo;
    public KeyCode LeftRo;
    public KeyCode Right;
    public KeyCode Left;
    public KeyCode Jump;

    //Controller keycode variables
    public KeyCode Controller_Jump_A;

    public void KeyCheck() {
        //Keyboard
        forward = Input.GetKey(Forward);
        rightRo = Input.GetKey(RightRo);
        leftRo = Input.GetKey(LeftRo);
        right = Input.GetKey(Right);
        left = Input.GetKey(Left);
        jump = Input.GetKey(Jump);
        
        

        //Controller
        controller_jump = Input.GetKey(Controller_Jump_A);
    }
}