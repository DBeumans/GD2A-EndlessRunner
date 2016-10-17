using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    [SerializeField]
    AudioClip object_Pickup_Sound;
    [SerializeField]
    AudioClip background_Song;

    Player_Color player_Color;

    AudioSource audio_Source;

    void Start()
    {
        player_Color = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Color>();

        audio_Source = gameObject.GetComponent<AudioSource>();
       // audio_Source.PlayOneShot(background_Song);
    }
    public void Play_Pickup_Sound()
    {
        audio_Source.PlayOneShot(object_Pickup_Sound);
    }

}
