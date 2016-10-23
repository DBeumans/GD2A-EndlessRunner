using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

    [SerializeField]
    AudioClip button_hover;
    [SerializeField]
    AudioClip button_click;

    AudioSource audio_source;

    float volume = .2f;

    void Start()
    {
        audio_source = gameObject.GetComponent<AudioSource>();
        audio_source.volume = volume;
    }

    public void onHover()
    {
        audio_source.PlayOneShot(button_hover);
    }
    public void onClick()
    {
        audio_source.PlayOneShot(button_click);
    }
}
