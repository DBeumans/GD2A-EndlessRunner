using UnityEngine;
using System.Collections;

public class PauzeBehaviour : MonoBehaviour {

    PauzeBehaviour _pauzeBehaviour;
    [SerializeField]
    public bool _isPauzed = false;
    [SerializeField]
    GameObject _pauze_Panel;

    Animator _animator;

    // Awake function is here to prevent the script turning off bug.
    void Awake()
    {
        _pauzeBehaviour = gameObject.GetComponent<PauzeBehaviour>();
        
        _pauzeBehaviour.enabled = true;
    }

    void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
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
            _pauze_Panel.SetActive(true);
            
            Time.timeScale = 0;
            Animations();

        }
        if(!value)
        {
            // Set Game To Unpauze State.
            _isPauzed = false;
            _pauze_Panel.SetActive(false);
            
            Time.timeScale = 1;
            Animations();
        }
    }

    void Animations()
    {
        if(_isPauzed)
        {
            _animator.SetBool("Pauze_Open", true);
        }
        else
        {
            _animator.SetBool("Pauze_Open", false);
        }
    }
}
