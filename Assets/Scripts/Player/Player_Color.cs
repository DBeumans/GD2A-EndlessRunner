using UnityEngine;
using System.Collections;

public class Player_Color : MonoBehaviour {

    private SpriteRenderer _cSprite;
	private string _cString = "white";
    
	private Color[] _color;

    AudioManager _audioManager;

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
        _audioManager = GameObject.FindObjectOfType<AudioManager>();

    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Pot" ||
         other.gameObject.tag == "Crate" ||
         other.gameObject.tag == "Tube") {
            _audioManager.Play_Pickup_Sound();
            Pot_Color pot = other.gameObject.GetComponent<Pot_Color>();
            //call the color function to set color
            // Debug.Log(pot.getColor() + " 1");
            setColor(pot.getColor());
            Destroy(other.gameObject);
        }
        /* //gebruiken we niet kost teveel tijd
        if (other.gameObject.tag == "Rain") {
            _cSprite.color = base.addRain();
        }
        if (other.gameObject.tag == "Sun") {
            _cSprite.color = base.addSun();
        }
        */
    }

    private void setColor(string newColor) {
       // Debug.Log(newColor + " 2");
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
    }

    public string getColor(){
        return _cString;
    }
}