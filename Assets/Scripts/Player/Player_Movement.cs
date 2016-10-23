using UnityEngine;
using System.Collections;

public class Player_Movement : InputBehaviour {

    [SerializeField]
    float jumpPower = 15f;
   
    float player_speed = 3f;

    [SerializeField]
    Transform Playertransform;
    [SerializeField]
    Transform groundedEnd;

    Rigidbody2D _rigidBody2D;

    AudioManager _audioManager;

    bool grounded = false;
    Player_Movement _playerMovement; // There is a bug that the player_movement script turns off when the game starts, this is to turn it back on again.
    //The player_movement script on the player turns off because of the arduino sopport, when there is no arduino connected it causes a bug, i dont know how, that the scripts turns off. To prevent it we are turning the script back on.
    // Use this for initialization
    void Awake()
    {
        _playerMovement = GetComponent<Player_Movement>();
        _playerMovement.enabled = true;
    }
    void Start ()
    {
        
        _rigidBody2D = gameObject.GetComponent<Rigidbody2D>();
        _audioManager = GameObject.FindObjectOfType<AudioManager>();
       
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
        if (jump || controller_up)
        {
            if (grounded)
            {
                _rigidBody2D.velocity = new Vector2(_rigidBody2D.velocity.x, 0);
                _rigidBody2D.AddForce(Vector2.up * jumpPower * 2);
                _audioManager.Play_Player_Jump_Sound();
            }
        }
        if (down || controller_down)
        {
            _rigidBody2D.AddForce(-Vector2.up * jumpPower * 2);
        }
        _rigidBody2D.AddForce(Vector2.left * player_speed * 2);
    }
    
    void CheckRaycast()
    {
        Debug.DrawLine(this.transform.position, groundedEnd.position, Color.green);

        grounded = Physics2D.Linecast(this.transform.position, groundedEnd.position, 1 << LayerMask.NameToLayer("Ground"));
    }
    

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player_play_area")
        {
            _rigidBody2D.velocity = Vector2.zero;
        }
    }

}
