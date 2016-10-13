using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Main_Menu : MonoBehaviour {

    public void Start_Game(int _scene)
    {
        SceneManager.LoadScene(_scene);
    }

    public void Quit_Game()
    {
        Application.Quit();
    }
}
