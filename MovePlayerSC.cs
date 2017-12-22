using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerSC : MonoBehaviour {

	public Vector2 speed = new Vector2(50, 50);
	public int Jump = 2;	
	public Collider2D GroundCollider;
	public LayerMask isGround;
	public Animator anim;
	
	private Vector2 movement;
	private bool grounded = false;
	private Rigidbody2D rb;
	private int CountJump = 0;
	private Transform Plane;
	
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D>();
		Plane = transform.Find("Plane");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		
		/////////////////////////RUN//////////////////////////
		
		float inputX = Input.GetAxis("Horizontal");
		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
		{
			movement = new Vector2(speed.x * inputX,
									rb.velocity.y);
			rb.velocity = movement;
			
			anim.SetBool("Move",true);///Animation
		}
		else
		{
			anim.SetBool("Move",false);///Animation
		}
		/////////////////////////FLIP//////////////////////////
		if(Plane.localScale.x > 0 && Input.GetKey(KeyCode.A))
			Plane.localScale = new  Vector3  (-Plane.localScale.x,Plane.localScale.y,0);
		if(Plane.localScale.x < 0 && Input.GetKey(KeyCode.D))
			Plane.localScale = new  Vector3  (-Plane.localScale.x,Plane.localScale.y,0);
		
		
		/////////////////////////JUMP/////////////////////////

		if((CountJump > 0) && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)))
		{
			movement.x = rb.velocity.x;
			movement.y = 10;
			CountJump--;
			rb.velocity = movement;
		}
		
		
	}
	
	void FixedUpdate()
	{
		grounded = GroundCollider.IsTouchingLayers(isGround);
		anim.SetBool("Grounded",grounded);///Animation
		
		if(grounded)
		{
			CountJump = Jump;
		}
	}
}

//IsTouchingLayers