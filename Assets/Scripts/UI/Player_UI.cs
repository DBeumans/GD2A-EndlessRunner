using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player_UI : MonoBehaviour {

    Player_Score player_score;
    Player_Health player_health;

    int Int_Player_Score;
    int Int_Player_HighScore;
    int Int_Player_Health;

    [SerializeField]
    Text Text_player_score;
    [SerializeField]
    Text Text_player_highscore;
    [SerializeField]
    Text Text_player_health;

    void Start()
    {
        player_score = GameObject.FindObjectOfType<Player_Score>();
        player_health = GameObject.FindObjectOfType<Player_Health>();

        Int_Player_HighScore = PlayerPrefs.GetInt("HighScore");
    }
    void Update()
    {
        Update_Player_Stats();
        Update_UI();
    }
    void Update_Player_Stats()
    {
        Int_Player_Score = player_score._player_Score;
        Int_Player_Health = player_health.player_Health;
    }
    void Update_UI()
    {
        Text_player_score.text = "Player Score: "+ Int_Player_Score.ToString();
        Text_player_highscore.text = "Player Highscore: " + Int_Player_HighScore.ToString();
        Text_player_health.text = "Player Health: " + Int_Player_Health.ToString();
    }
}
