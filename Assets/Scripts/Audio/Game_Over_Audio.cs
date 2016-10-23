using UnityEngine;
using System.Collections;

public class Game_Over_Audio : MonoBehaviour {

    [SerializeField]
    AudioClip game_over_song;

    AudioSource audio_source;

    void Start()
    {
        audio_source = gameObject.GetComponent<AudioSource>();
        PlaySong();
    }

    void PlaySong()
    {
        audio_source.PlayOneShot(game_over_song);
    }
}
