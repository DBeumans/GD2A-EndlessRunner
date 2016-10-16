using UnityEngine;
using System.Collections;

public class House_Color : MonoBehaviour {

    private SpriteRenderer _cSprite;
    private string _cString = "white";

    Player_Score _player_Score;
    
	private Color[] _color;

    private void Start() {
        _color = new Color[9];
        _color[0] = new Color(255, 0, 0, 1); //red
		_color[1] = new Color(255, 127, 0, 1);//orange
		_color[2] = new Color(255, 255, 0 , 1); // yellow
		_color[3] = new Color(0, 255, 0, 1); //green
		_color[4] = new Color(0, 0, 255, 1); //dark blue
		_color[5] = new Color(0, 255, 255, 1);//light blue
		_color[6] = new Color(255, 0, 255, 1);//pink
		_color[7] = new Color(127, 0, 255, 1);//purple
		_color[8] = new Color(255, 255, 255, 1);//white

		_cSprite = GetComponent<SpriteRenderer>();
		_cSprite.color = new Color(255, 255, 255, 1);

        _player_Score = GameObject.FindObjectOfType<Player_Score>();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            if(this.gameObject.tag =="House")
            {
                Player_Color player = other.gameObject.GetComponent<Player_Color>();
                //call the color function to set color
                // Debug.Log(player.getColor() + " 1");
                setColor(player.getColor());
                _player_Score._player_Score++;
                this.gameObject.tag = "House_Colored";

            }
            else
            {
                // house have other tag and is already colored.
            }
        }
    }

    private void setColor(string newColor) {
        //Debug.Log(newColor + " 2");
                switch (newColor) {
					case "white":
						_cSprite.color = _color[8];
						_cString = newColor;
					break;
					case "red":
						_cSprite.color = _color[0];
						_cString = newColor;
                break;
					case "orange": 
						_cSprite.color = _color[1];
						_cString = newColor;
                break;
					case "yellow":
						_cSprite.color = _color[2];
						_cString = newColor;

                break;
					case "green":
						_cSprite.color = _color[3];
						_cString = newColor;
                break;
					case "darkBlue":
						_cSprite.color = _color[4];
						_cString = newColor;
                break;
					case "lightBlue":
						_cSprite.color = _color[5];
						_cString = newColor;
                break;
					case "pink":
						_cSprite.color = _color[6];
						_cString = newColor;
                break;
					case "purple":
						_cSprite.color = _color[7];
						_cString = newColor;
                break;
					default:
						Debug.Log("Error ColorBehaviour house newColor");
					break;
                }
    }
}
