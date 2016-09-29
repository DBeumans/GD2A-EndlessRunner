using UnityEngine;
using System.Collections;

public class ColorBehaviour : MonoBehaviour {
	
	[SerializeField]
	private SpriteRenderer _cSprite;
	[SerializeField]
	private string _cString = "white";

	private Color[] _color;

	void Stard () {
		_color[0] = new Color(255, 0, 0, 1); //red
		_color[1] = new Color(255, 127.5f, 0, 1);//orange
		_color[2] = new Color(255, 255, 0 , 1); // yellow
		_color[3] = new Color(0, 255, 0, 1); //green
		_color[4] = new Color(0, 0, 255, 1); //dark blue
		_color[5] = new Color(0, 255, 255, 1);//light blue
		_color[6] = new Color(255, 0, 255, 1);//pink
		_color[7] = new Color(127.5f, 0, 255, 1);//purple
		_color[8] = new Color(255, 255, 255, 1);//white


		_cSprite = GetComponent<SpriteRenderer>();
		_cSprite.color = new Color(255, 255, 255, 1);
	}

    public string getColor() {
		return _cString;
    }

	public void setColor(string weather, string newColor) {
		switch (weather) {
			case "normal": 
				switch (newColor) {
					case "red":
						switch (_cString) {
							case "white":
								_cSprite.color = _color[0];
								_cString = "red";
							break;
							case "orange": 
								_cSprite.color = _color[0];
								_cString = "red";
							break;
							case "yellow":
								_cSprite.color = _color[1];
								_cString = "orange";
							break;
							case "green":
								_cSprite.color = _color[1];
								_cString = "orange";
							break;
							case "darkBlue":
								_cSprite.color = _color[7];
								_cString = "purple";
							break;
							case "lightBlue":
								_cSprite.color = _color[6];
								_cString = "pink";
							break;
							case "pink":
								_cSprite.color = _color[0];
								_cString = "red";
							break;
							case "purple":
								_cSprite.color = _color[0];
								_cString = "red";
							break;
						}
					break;
					case "yellow":
						switch (_cString) {
							case "white":
								_cSprite.color = _color[2];
								_cString = "yellow";
							break;
							case "red":
								_cSprite.color = _color[1];
								_cString = "orange";
							break;
							case "orange": 
								_cSprite.color = _color[2];
								_cString = "yellow";
							break;
							case "darkBlue":
								_cSprite.color = _color[3];
								_cString = "green";
							break;
							case "lightBlue":
								_cSprite.color = _color[3];
								_cString = "green";
							break;
							case "pink":
								_cSprite.color = _color[5];
								_cString = "lightBlue";
							break;
							case "purple":
								_cSprite.color = _color[6];
								_cString = "pink";
							break;
						}
					break;
					case "darkBlue":
						switch (_cString) {
							case "white":
								_cSprite.color = _color[4];
								_cString = "darkBlue";
							break;
							case "red":
								_cSprite.color = _color[7];
								_cString = "purple";
							break;
							case "orange": 
								_cSprite.color = _color[3];
								_cString = "green";
							break;
							case "yellow":
								_cSprite.color = _color[3];
								_cString = "green";
							break;
							case "green":
								_cSprite.color = _color[4];
								_cString = "darkBlue";
							break;
							case "lightBlue":
								_cSprite.color = _color[4];
								_cString = "darkBlue";
							break;
							case "pink":
								_cSprite.color = _color[5];
								_cString = "lightBlue";
							break;
							case "purple":
								_cSprite.color = _color[4];
								_cString = "darkBlue";
							break;
						}
					break;
				}
			break;
			case "rain":
				switch (_cString) {
					case "red":
						_cSprite.color = _color[1];
						_cString = "orange";
					break;
					case "orange": 
						_cSprite.color = _color[2];
						_cString = "yellow";
					break;
					case "yellow":
						_cSprite.color = _color[8];
						_cString = "white";
					break;
					case "green":
						_cSprite.color = _color[2];
						_cString = "yellow";
					break;
					case "darkBlue":
						_cSprite.color = _color[5];
						_cString = "lightBlue";
					break;
					case "lightBlue":
						_cSprite.color = _color[8];
						_cString = "white";
					break;
					case "pink":
						_cSprite.color = _color[5];
						_cString = "lightBlue";
					break;
					case "purple":
						_cSprite.color = _color[6];
						_cString = "pink";
					break;
				}
			break;
			case "sun":
				switch (_cString) {
					case "white":
						_cSprite.color = _color[2];
						_cString = "yellow";
					break;
					case "red":
						_cSprite.color = _color[1];
						_cString = "orange";
					break;
					case "orange": 
						_cSprite.color = _color[2];
						_cString = "yellow";
					break;
					case "green":
						_cSprite.color = _color[5];
						_cString = "lightBlue";
					break;
					case "darkBlue":
						_cSprite.color = _color[6];
						_cString = "pink";
					break;
					case "lightBlue":
						_cSprite.color = _color[2];
						_cString = "yellow";
					break;
					case "pink":
						_cSprite.color = _color[2];
						_cString = "yellow";
					break;
					case "purple":
						_cSprite.color = _color[6];
						_cString = "pink";
					break;
				}
			break;
			case "pot":
				float random = Random.Range(0, 2.9999999f);
				if(random >= 0 && random < 1) {
					_cSprite.color = _color[0];
				}
				if(random >= 1 && random < 2) {
					_cSprite.color = _color[0];
				}
				if(random >= 2 && random < 3) {
					_cSprite.color = _color[0];
				}
			break;
			case "house":
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
				}
			break;
		}
	}
}
