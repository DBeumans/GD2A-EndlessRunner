using UnityEngine;
using System.Collections;

public class PauzeBehaviour : InputBehaviour {

    bool _pauzeEnabled = false;

    void FixedUpdate()
    {
        KeysState();
    }

    void KeysState()
    {
        if(escapeButton)
        {
            escapeButton = false;
            _pauzeEnabled = true;
        }
        else
        {
            
        }
    }
    void Pauze(bool value)
    {
        
    }
}
