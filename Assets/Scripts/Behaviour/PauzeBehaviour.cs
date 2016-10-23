using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauzeBehaviour : MonoBehaviour {

    PauzeBehaviour _pauzeBehaviour;
    [SerializeField]
    public bool _isPauzed = false;
    [SerializeField]
    GameObject _pauze_Panel;

    AudioManager _audioManager;

    HideUI hide_UI;
    // Awake function is here to prevent the script turning off bug.
    void Awake()
    {
        _pauzeBehaviour = gameObject.GetComponent<PauzeBehaviour>();
        
        _pauzeBehaviour.enabled = true;
    }

    void Start()
    {
        _audioManager = GameObject.FindObjectOfType<AudioManager>();
        hide_UI = gameObject.GetComponent<HideUI>();
        _pauze_Panel.SetActive(false);
    }

    void Update()
    {
        KeysState();
        CheckGamePauze();
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
            hide_UI.Hide_UI_Elements(true);
            Time.timeScale = 0;
        }
        if(!value)
        {
            // Set Game To Unpauze State.
            _isPauzed = false;
            _pauze_Panel.SetActive(false);
            hide_UI.Hide_UI_Elements(false);
            Time.timeScale = 1;
        }
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void UnpauzeGame()
    {
        PauzeGame(false);
    }

    void CheckGamePauze()
    {
        if(!_isPauzed)
        {
            _audioManager.MuteAudio(false);
        }
        else
        {
            _audioManager.MuteAudio(true);
        }
    }
}
