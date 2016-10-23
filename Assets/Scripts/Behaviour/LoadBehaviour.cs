using UnityEngine;
using System.Collections;

public class LoadBehaviour : MonoBehaviour {

    public int highscore;
	void Awake ()
    {
        LoadGame();
	}

    void Start()
    {
        LoadGame();
    }

    void LoadGame()
    {
        highscore = PlayerPrefs.GetInt("HighScore");
    }

}
