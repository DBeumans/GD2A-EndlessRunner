using UnityEngine;
using System.Collections;

public class InputBehaviour : MonoBehaviour {

    public bool forward = false;
    public bool rightRo = false;
    public bool leftRo = false;
    public bool right = false;
    public bool left = false;
    public bool jump = false;

    public KeyCode Forward;
    public KeyCode RightRo;
    public KeyCode LeftRo;
    public KeyCode Right;
    public KeyCode Left;
    public KeyCode Jump;

    public void KeyCheck() {
        forward = Input.GetKey(Forward);
        rightRo = Input.GetKey(RightRo);
        leftRo = Input.GetKey(LeftRo);
        right = Input.GetKey(Right);
        left = Input.GetKey(Left);
        jump = Input.GetKey(Jump);
    }
}