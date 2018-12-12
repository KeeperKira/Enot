using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallJumpSC : MonoBehaviour {
	
	public Collider2D Front;
	public Collider2D Back;
	public LayerMask isWall;
	public Vector2 Force;
	public float timeFly = 0.3f;
	
	private bool slideF,slideB;	
	private Rigidbody2D rb;
	private MovePlayerSC movePlayer;

	// Use this for initialization
	void Start () 
	{
		movePlayer = GetComponent<MovePlayerSC>();
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		slideF = Front.IsTouchingLayers(isWall);
		slideB = Back.IsTouchingLayers(isWall);
		
		if(slideF || slideB)
		{
			rb.velocity = new Vector2(rb.velocity.x,-2);
		}

		
		if((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W)) && slideF)
		{
			movePlayer.Block(timeFly);
			Force.x = -Mathf.Abs(Force.x); 
			rb.velocity = Force;
		}
		
		if((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W)) && slideB)
		{
			movePlayer.Block(timeFly);
			Force.x = Mathf.Abs(Force.x);
			rb.velocity = Force;
		}

	}
	
	void FixedUpdate()
	{

	}
}
