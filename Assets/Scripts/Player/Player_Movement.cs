using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {

    [SerializeField]
    float jumpPower = 20f;

    [SerializeField]
    Transform Playertransform;
    [SerializeField]
    Transform groundedEnd;

    Rigidbody2D rb2d;

    bool grounded = false;

    // Use this for initialization
    void Start ()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        CheckKeyStatement();
        CheckRaycast();

    }

    void CheckKeyStatement()
    {
        // jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
                rb2d.AddForce(Vector2.up * jumpPower * 2);
            }          
        }
    }

    void CheckRaycast()
    {
        Debug.DrawLine(this.transform.position, groundedEnd.position, Color.green);

        grounded = Physics2D.Linecast(this.transform.position, groundedEnd.position, 1 << LayerMask.NameToLayer("Ground"));
    }
}
