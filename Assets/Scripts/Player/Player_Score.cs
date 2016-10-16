using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player_Score : House_Color {

    public int _player_Score;


    [SerializeField]
    Text _player_Score_Text;

    void Start()
    {
        StartCoroutine("Score_Updator");
    }

    void Update()
    {
        
        _player_Score_Text.text = _player_Score.ToString();
    }
}
