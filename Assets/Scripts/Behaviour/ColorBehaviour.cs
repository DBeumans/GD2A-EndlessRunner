using UnityEngine;
using System.Collections;

public class ColorBehaviour : MonoBehaviour {
	/*
	[SerializeField]
	private SpriteRenderer _cSprite;
	[SerializeField]
	private string _cString = "white";

	private Color[] _color;

	private void Start () {
		_color = new Color[9];
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

	public Color setPlayer(string newColor) {
		switch (newColor) {
			case "red":
				switch (_cString) {
					case "white":
						_cString = "red";
						return _color[0];
					break;
					case "orange": 
						_cString = "red";
						return _color[0];
					break;
					case "yellow":
						_cString = "orange";
						return _color[1];
					break;
					case "green":
						_cString = "orange";
						return _color[1];
					break;
					case "darkBlue":
						_cString = "purple";
						return _color[7];
					break;
					case "lightBlue":
						_cString = "pink";
						return _color[6];
					break;
					case "pink":
						_cString = "red";
						return _color[0];
					break;
					case "purple":
						_cString = "red";
						return _color[0];
					break;
				}
			break;
			case "yellow":
				switch (_cString) {
					case "white":
						_cString = "yellow";
						return _color[2];
					break;
					case "red":
						_cString = "orange";
						return _color[1];
					break;
					case "orange": 
						_cString = "yellow";
						return _color[2];
					break;
					case "darkBlue":
						_cString = "green";
						return _color[3];
					break;
					case "lightBlue":
						_cString = "green";
						return _color[3];
					break;
					case "pink":
						_cString = "lightBlue";
						return _color[5];
					break;
					case "purple":
						_cString = "pink";
						return _color[6];
					break;
				}
			break;
			case "darkBlue":
				switch (_cString) {
					case "white":
						_cString = "darkBlue";
						return _color[4];
					break;
					case "red":
						_cString = "purple";
						return _color[7];
					break;
					case "orange": 
						_cString = "green";
						return _color[3];
					break;
					case "yellow":
						_cString = "green";
						return _color[3];
					break;
					case "green":
						_cString = "darkBlue";
						return _color[4];
					break;
					case "lightBlue":
						_cString = "darkBlue";
						return _color[4];
					break;
					case "pink":
						_cString = "lightBlue";
						return _color[5];
					break;
					case "purple":
						_cString = "darkBlue";
						return _color[4];
					break;
				}
			break;
		}
		return _color[8];
	}

	public Color setHouse(string newColor) {
		switch (newColor) {
			case "white":
				_cString = newColor;
				return _color[8];
			break;
			case "red":
				_cString = newColor;
				return _color[0];
			break;
			case "orange": 
				_cString = newColor;
				return _color[1];
			break;
			case "yellow":
				_cString = newColor;
				return _color[2];
			break;
			case "green":
				_cString = newColor;
				return _color[3];
			break;
			case "darkBlue":
				_cString = newColor;
				return _color[4];
			break;
			case "lightBlue":
				_cString = newColor;
				return _color[5];
			break;
			case "pink":
				_cString = newColor;
				return _color[6];
			break;
			case "purple":
				_cString = newColor;
				return _color[7];
			break;
		}
		return _color[8];
	}
	/* //gebruiken we niet kost teveel tijd
	public Color addSun() {
		switch (_cString) {
			case "white":
				_cString = "yellow";
				return _color[2];
			break;
			case "red":
				_cString = "orange";
				return _color[1];
			break;
			case "orange": 
				_cString = "yellow";
				return _color[2];
			break;
			case "green":
				_cString = "lightBlue";
				return _color[5];
			break;
			case "darkBlue":
				_cString = "pink";
				return _color[6];
			break;
			case "lightBlue":
				_cString = "yellow";
				return _color[2];
			break;
			case "pink":
				_cString = "yellow";
				return _color[2];
			break;
			case "purple":
				_cString = "pink";
				return _color[6];
			break;
		}
		return _color[8];
	}

	public Color addRain() {
		switch (_cString) {
			case "red":
				_cString = "orange";
				return _color[1];
			break;
			case "orange": 
				_cString = "yellow";
				return _color[2];
			break;
			case "yellow":
				_cString = "white";
				return _color[8];
			break;
			case "green":
				_cString = "yellow";
				return _color[2];
			break;
			case "darkBlue":
				_cString = "lightBlue";
				return _color[5];
			break;
			case "lightBlue":
				_cString = "white";
				return _color[8];
			break;
			case "pink":
				_cString = "lightBlue";
				return _color[5];
			break;
			case "purple":
				_cString = "pink";
				return _color[6];
			break;
		}
		return _color[8];
	}*/
}
