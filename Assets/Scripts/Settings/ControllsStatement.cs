using UnityEngine;
using System.Collections;

public class ControllsStatement : MonoBehaviour {

    //Vars
    
    bool _keyboard = true;
    bool _controller = false;


    
    public void ChangeControlls(string controllType)
    {
        if(controllType == "Keyboard")
        {
            _keyboard = true;
        }
        if(controllType == "Controller")
        {
            _controller = true;
        }
    }

}
