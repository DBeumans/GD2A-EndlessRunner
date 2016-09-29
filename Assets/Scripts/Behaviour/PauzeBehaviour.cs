using UnityEngine;
using System.Collections;

public class PauzeBehaviour : MonoBehaviour {

    PauzeBehaviour _pauzeBehaviour;
    [SerializeField]
    public bool _isPauzed = false;
    // Awake function is here to prevent the script turning off bug.
    void Awake()
    {
        _pauzeBehaviour = gameObject.GetComponent<PauzeBehaviour>();
        _pauzeBehaviour.enabled = true;
    }
    void Update()
    {
        KeysState();
    }

    void KeysState()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (!_isPauzed)
            {   
                PauzeGame(true);
            }
            else if (_isPauzed)
            {
                PauzeGame(false);
            }
        }
    }

    void PauzeGame(bool value)
    {
        if(value)
        {
            // Set Game To Pauze State.
            _isPauzed = true;
            Time.timeScale = 0;
            
        }
        if(!value)
        {
            // Set Game To Unpauze State.
            _isPauzed = false;
            Time.timeScale = 1;
        }
    }
}
