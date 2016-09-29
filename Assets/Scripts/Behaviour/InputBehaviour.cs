using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class InputBehaviour : ControllsStatement {
    
    public bool forward = false;
    public bool rightRo = false;
    public bool leftRo = false;
    public bool right = false;
    public bool left = false;
    public bool jump = false;
    public bool escapeButton = false;

    public KeyCode Forward;
    public KeyCode RightRo;
    public KeyCode LeftRo;
    public KeyCode Right;
    public KeyCode Left;
    public KeyCode Jump;
    public KeyCode EscapeButton;

    private bool portSet; 
    private SerialPort serialP = new SerialPort("COM1" , 9600);
    
    private void Awake() {
        /*for(float i = 1; i <= 10; i++) {
            if (!portSet) {
            serialP = new SerialPort("COM"+i , 9600);
                if (serialP.IsOpen) {
                    try {
                        portSet = true;
                    } catch {}
                    } else {

                }
            }
        }*/
        serialP.Open();
        serialP.ReadTimeout = 1;
    }
    
    private void Arduino(string _Input) {
        switch (_Input)
        {
            case "forward":
                forward = true;
                break;
            case "rightRo":
                rightRo = true;
                break;
            case "leftRo":
                leftRo = true;
                break;
            case "right":
                right = true;
                break;
            case "left":
                left = true;
                break;
            case "jump":
                jump = true;
                break;
            case "escapeButton":
                escapeButton = true;
                break;
        }
    }

    public void KeyCheck() {
        
        forward = Input.GetKey(Forward);
        rightRo = Input.GetKey(RightRo);
        leftRo = Input.GetKey(LeftRo);
        right = Input.GetKey(Right);
        left = Input.GetKey(Left);
        jump = Input.GetKey(Jump);
        escapeButton = Input.GetKey(EscapeButton);
        
        /*if (serialP.IsOpen) {
            try {
                string _Input = serialP.ReadByte().ToString();
                Arduino(_Input);
            } catch {}
        } else {

        }*/
    }
}
