using UnityEngine;
using System.Collections;

public class SaveBehaviour : MonoBehaviour {

    Player_Score player_Score;

    int PlayerScore, IncommingScore, highscore;

    public void SaveGame()
    {
        player_Score = GameObject.FindObjectOfType<Player_Score>();
        IncommingScore = player_Score._player_Score;

        PlayerScore = IncommingScore;
        PlayerPrefs.SetInt("PlayerScore", PlayerScore);
        PlayerPrefs.Save();
        Debug.Log("Saved!");
        SetHighscore();
    }

    void SetHighscore()
    {
        highscore = PlayerPrefs.GetInt("HighScore");
        PlayerScore = PlayerPrefs.GetInt("PlayerScore");
        if(PlayerScore > highscore)
        {
            Debug.Log("Set new highscore!" + PlayerPrefs.GetInt("HighScore"));
            highscore = PlayerScore;
            PlayerPrefs.SetInt("HighScore", highscore);
            PlayerPrefs.Save();
        }
        else
        {
            Debug.Log("No new highscore!");
            Debug.Log(PlayerPrefs.GetInt("HighScore"));
        }
    }
}
