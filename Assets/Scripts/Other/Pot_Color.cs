using UnityEngine;
using System.Collections;

public class Pot_Color : MonoBehaviour {

	private SpriteRenderer _cSprite;
	private string _cString = "white";
    
    private void Start() {
		_cSprite = GetComponent<SpriteRenderer>();
        int random = Random.Range(0, 3);
		switch (random) {
			case 0:
				_cSprite.color = new Color(255, 0, 0, 1);
				_cString = "red";
			break;
			case 1:
				_cSprite.color = new Color(255, 255, 0 , 1);
				_cString = "yellow";
			break;
			case 2:
				_cSprite.color = new Color(0, 0, 255, 1);;
		    	_cString = "darkBlue";
			break;
		}
    }

    public string getColor() {
        return _cString;
    }
}