using UnityEngine;
using System.Collections;

public class Pot_Color : MonoBehaviour {

    [SerializeField]
	private SpriteRenderer _cSprite;
	[SerializeField]
	private string _cString = "white";
    
    private void Stard() {
        int random = Random.Range(0, 2);
		switch (random) {
			case 0:
				_cSprite.color = new Color(255, 0, 0, 1);
				_cString = "red";
				Debug.Log("red");
			break;
			case 1:
				_cSprite.color = new Color(255, 255, 0 , 1);
				_cString = "yellow";
				Debug.Log("yellow");
			break;
			case 2:
				_cSprite.color = new Color(0, 0, 255, 1);;
		    	_cString = "darkBlue";
				Debug.Log("darkBlue");
			break;
		}
    }

    public string getColor() {
        return _cString;
    }
}