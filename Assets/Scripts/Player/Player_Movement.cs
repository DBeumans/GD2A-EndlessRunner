using UnityEngine;
using System.Collections;

public class Player_Movement : InputBehaviour {

    [SerializeField]
    float jumpPower = 20f;

    [SerializeField]
    Transform Playertransform;
    [SerializeField]
    Transform groundedEnd;

    Rigidbody2D _rigidBody2D;

    bool grounded = false;

    // Use this for initialization
    void Start ()
    {
        _rigidBody2D = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        CheckKeyStatement();
        CheckRaycast();
        KeyCheck();
    }

    void CheckKeyStatement()
    {
        // jump
        if (jump )
        {
            if (grounded)
            {
                _rigidBody2D.velocity = new Vector2(_rigidBody2D.velocity.x, 0);
                _rigidBody2D.AddForce(Vector2.up * jumpPower * 2);
            }          
        }
    }

    void CheckRaycast()
    {
        Debug.DrawLine(this.transform.position, groundedEnd.position, Color.green);

        grounded = Physics2D.Linecast(this.transform.position, groundedEnd.position, 1 << LayerMask.NameToLayer("Ground"));
    }
}
