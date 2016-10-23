using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Game_Over_UI : MonoBehaviour {

    int score;
    int highscore;

    [SerializeField]
    Text score_text;
    [SerializeField]
    Text highscore_text;

	void Start ()
    {
        score = PlayerPrefs.GetInt("PlayerScore");
        highscore = PlayerPrefs.GetInt("HighScore");
        ShowText();

    }
	
    void ShowText()
    {
        score_text.text = "Score: " + score.ToString();
        highscore_text.text = "Highscore: " + highscore.ToString();
    }
}
