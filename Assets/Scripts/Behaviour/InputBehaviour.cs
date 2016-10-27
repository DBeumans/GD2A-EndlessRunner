using UnityEngine;
using System.Collections;


public class InputBehaviour : MonoBehaviour {
    
    public bool forward = false;
    public bool rightRo = false;
    public bool leftRo = false;
    public bool right = false;
    public bool left = false;
    public bool jump = false;
    public bool escapeButton = false;
    public bool down = false;
    // Controller
    public bool controller_up;
    public bool controller_down;

    public KeyCode Forward;
    public KeyCode RightRo;
    public KeyCode LeftRo;
    public KeyCode Right;
    public KeyCode Left;
    public KeyCode Jump;
    public KeyCode EscapeButton;
    public KeyCode Down;
    // Controller
    public KeyCode Controller_Up;
    public KeyCode Controller_Down;

   // private bool portSet; 
    //private SerialPort serialP = new SerialPort("COM7" , 9600);
    
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
        
        //serialP.Open();
       // serialP.ReadTimeout = 1;
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
            case "down":
                down = true;
                break;
        }
    }

    public void KeyCheck() {
        
        forward = Input.GetKey(Forward);
        rightRo = Input.GetKey(RightRo);
        leftRo = Input.GetKey(LeftRo);
        right = Input.GetKey(Right);
        left = Input.GetKey(Left);
        jump = Input.GetKeyDown(Jump);
        escapeButton = Input.GetKey(EscapeButton);
        down = Input.GetKey(Down);

        // Controller
        controller_up = Input.GetKey(Controller_Up);
        controller_down = Input.GetKey(Controller_Down);

        //if (!serialP.IsOpen) { serialP.Open(); }
        /*
        if (serialP.IsOpen) {
            try {
                string _Input = serialP.ReadLine().ToString();
                Arduino(_Input);
                print(_Input);
            } catch(System.Exception) {}
        } else {

        }
        */

        
    }
    /*void Update()
    {
        int Y;
        int X;
        string value = serialP.ReadLine(); //Read the information
        string[] vec3 = value.Split(',');
        X = int.Parse(vec3[0]);
        Y = int.Parse(vec3[1]);

        
    }*/
}
