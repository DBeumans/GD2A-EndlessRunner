using UnityEngine;
using System.Collections;

public class ColorBehaviour : MonoBehaviour {
	
	SpriteRenderer _color;

	void Awake () {
		_color = GetComponent<SpriteRenderer>();
		_color.color = new Color(0, 0, 0, 1);
	}

	void Update () {

	}

    void GetColor() {

    }

	void SetColor(string newColor) {
		
	}
}
