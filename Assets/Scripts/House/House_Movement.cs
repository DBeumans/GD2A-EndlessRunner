using UnityEngine;
using System.Collections;

public class House_Movement : MonoBehaviour {

    [SerializeField]
    float MovementSpeed = 1.5f;

	// Update is called once per frame
	void Update ()
    {
            transform.Translate(Vector2.right * MovementSpeed * Time.deltaTime);  
    }
}
