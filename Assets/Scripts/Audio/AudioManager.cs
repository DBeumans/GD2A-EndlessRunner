using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    [SerializeField]
    AudioClip object_Pickup_Sound;
    [SerializeField]
    AudioClip[] background_Songs;

    Player_Color player_Color;

    AudioSource audio_Source;

    int randomSong;

    void Start()
    {
        player_Color = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Color>();

        audio_Source = gameObject.GetComponent<AudioSource>();

        PlayRandomStartSong();
        
    }
    public void Play_Pickup_Sound()
    {
        audio_Source.PlayOneShot(object_Pickup_Sound);
    }

    void PlayRandomStartSong()
    {
        randomSong = Random.Range(0, background_Songs.Length);
        audio_Source.PlayOneShot(background_Songs[randomSong]);
    }

}
