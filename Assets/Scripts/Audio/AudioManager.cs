using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    [SerializeField]
    AudioClip object_Pickup_Sound;
    [SerializeField]
    AudioClip[] background_Songs;

    [SerializeField]
    AudioClip player_jump;

    Player_Color player_Color;

    AudioSource audio_Source;

    int randomSong;

    void Start()
    {
        player_Color = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Color>();

        audio_Source = gameObject.GetComponent<AudioSource>();

        //PlayRandomStartSong();
        PlayNextSong();
        
    }
    public void Play_Pickup_Sound()
    {
        audio_Source.PlayOneShot(object_Pickup_Sound);
    }

    public void Play_Player_Jump_Sound()
    {
        audio_Source.PlayOneShot(player_jump);
    }
    /*
    void PlayRandomStartSong()
    {
        randomSong = Random.Range(0, background_Songs.Length);
        audio_Source.PlayOneShot(background_Songs[randomSong]);
    }
    */
    void PlayNextSong()
    {
        audio_Source.clip = background_Songs[Random.Range(0, background_Songs.Length)];
        audio_Source.Play();
        Invoke("PlayNextSong", audio_Source.clip.length);
    }

    public void MuteAudio(bool value)
    {
        if(value)
        {
            audio_Source.Pause();
        }
        else
        {
            audio_Source = gameObject.GetComponent<AudioSource>();
            audio_Source.UnPause();
        }
        
    }

    

}
