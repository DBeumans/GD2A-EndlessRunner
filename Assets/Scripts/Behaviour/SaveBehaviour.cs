using UnityEngine;
using System.Collections;

public class SaveBehaviour : MonoBehaviour {

    Player_Score player_Score;

    int Highscore, IncommingScore;

    void Start()
    {
        player_Score = GameObject.FindObjectOfType<Player_Score>();
    }

    public void SaveGame()
    {
        IncommingScore = player_Score._player_Score;

        if(IncommingScore < Highscore)
        {
            // nothing
        }
        Highscore = IncommingScore;

        // Player Prefs

        PlayerPrefs.SetInt("HighScore", Highscore);
    }
}
