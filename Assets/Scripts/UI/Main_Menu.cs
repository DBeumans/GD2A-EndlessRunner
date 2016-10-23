using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Main_Menu : MonoBehaviour {

    int highscore;
    [SerializeField]
    Text highscore_text;

    void Start()
    {
        highscore = PlayerPrefs.GetInt("HighScore");
        ShowHighscore();
    }
    public void Start_Game(int _scene)
    {
        SceneManager.LoadScene(_scene);
    }

    public void Quit_Game()
    {
        Application.Quit();
    }

    void ShowHighscore()
    {
        highscore_text.text = "Highscore: " + highscore.ToString();
    }
}
