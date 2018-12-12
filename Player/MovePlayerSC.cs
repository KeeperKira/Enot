using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerSC : MonoBehaviour {

	public Vector2 speed = new Vector2(50, 50);
	public int Jumps = 2;	
	public int JumpForce = 12;
	public float timeFly = 0.3f;
	public Vector2 forceWallJump;
	public Transform GroundCollider;
	public Collider2D Front;
	public Collider2D Back;	
	public LayerMask isGround;
	public LayerMask isWall;
	public Animator anim;
	
	private bool slideF,slideB;
	private Vector2 movement;
	private bool AnimationMove = false;
	private bool grounded = false;
	private Rigidbody2D rb;
	private int CountJump = 0;
	private Transform Plane;
	private bool block = false;
	private float timeBlock;
	private bool triggerMoveLeft,triggerMoveRight;
	
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D>();
		Plane = transform.Find("Plane");
		Enemy.Player = this.gameObject;
        Enemy.PlayerRB = rb;
        Enemy.Plane = transform.Find("Plane");
    }
	
	public void Block(float time)
	{
		timeBlock = time;
	}
	
	// Update is called once per frame
	void Update () 
	{	
		slideF = Front.IsTouchingLayers(isWall);
		slideB = Back.IsTouchingLayers(isWall);
		

		
		/////////////////////////JUMP/////////////////////////
		if( (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)))
		{
			Jump();
		}

      //  if (Input.GetKeyDown(KeyCode.Joystick1Button6))
        {
      //      Jump();
        }
      //  if (Input.GetKeyDown(KeyCode.Joystick1Button7))
        {
      //      Jump();
        }
     //   if (Input.GetKeyDown(KeyCode.Joystick1Button8))
        {
     //       Jump();
        }
        if (Input.GetButton("Left1"))
        {
            Jump();
        }




        grounded = Physics2D.OverlapCircle(GroundCollider.gameObject.transform.position, 0.3f, isGround);
		anim.SetBool("Grounded",grounded);///Animation		
		anim.SetFloat("SpeedY",rb.velocity.y);
		
		if(timeBlock > 0)
		{
			timeBlock -= Time.deltaTime;
			block = true;
		}
		else
		{
			block = false;
		}
		
		if(grounded)
		{
			CountJump = Jumps;
		}
		
		
	}

	
	void FixedUpdate()
	{
		/////////////////////////RUN//////////////////////////	

		if(Input.GetKey(KeyCode.A))
			MoveLeft();	
				
		if(Input.GetKey(KeyCode.D))
			MoveRight();

       // if (Input.GetKey(KeyCode.Joystick1Button2))
        {
       //     MoveLeft();
        }
       // if (Input.GetKey(KeyCode.Joystick1Button3))
        {
       //     MoveRight();
        }





        if (triggerMoveRight)/////Mobile Run////
			MoveRight();
		if(triggerMoveLeft)/////Mobile Run////
			MoveLeft();
			
		if((slideF || slideB) && !block)
		{
			rb.velocity = new Vector2(rb.velocity.x,-2);
		}
			
		/////////////////////////ANIMATIONMOVE///////////////////////////////

		anim.SetBool("Move",AnimationMove);///Animation
		AnimationMove = false;
	}
	
	public void MoveLeft()
	{
		if(!block)
		{
			movement = new Vector2(-speed.x , rb.velocity.y);
			rb.velocity = movement;	
			if(Plane.localScale.x > 0 )
				Plane.localScale = new  Vector3  (-Plane.localScale.x,Plane.localScale.y,0);
		
			AnimationMove =true;
		}
	}
	
	public void MoveRight()
	{
		if(!block)
		{
			movement = new Vector2(speed.x , rb.velocity.y);
			rb.velocity = movement;	
			if(Plane.localScale.x < 0 )
				Plane.localScale = new  Vector3  (-Plane.localScale.x,Plane.localScale.y,0);
		
			AnimationMove =true;
		}
	}
	
	public void PainJump()
	{
		movement.x = rb.velocity.x;
		movement.y = JumpForce;
		rb.velocity = movement;
	}
	public void Jump()
	{
        if(!block)
        {
            if (CountJump > 0)
            {
                movement.x = rb.velocity.x;
                movement.y = JumpForce;
                CountJump--;
                rb.velocity = movement;
            }
            /////////////////////////WALLJUMP/////////////////////////
            if (slideF)
            {
                if (Plane.localScale.x > 0)
                    Plane.localScale = new Vector3(-Plane.localScale.x, Plane.localScale.y, 0);

                Block(timeFly);
                forceWallJump.x = -Mathf.Abs(forceWallJump.x);
                rb.velocity = forceWallJump;
            }
            if (slideB)
            {
                if (Plane.localScale.x < 0)
                    Plane.localScale = new Vector3(-Plane.localScale.x, Plane.localScale.y, 0);

                Block(timeFly);
                forceWallJump.x = Mathf.Abs(forceWallJump.x);
                rb.velocity = forceWallJump;
            }
        }
		
	}
	public void  ButtonLeftDown()
	{
		triggerMoveLeft = true;
	}
	public void ButtonLeftUp()
	{
		triggerMoveLeft = false;
	}
	public void ButtonRightDown()
	{
		triggerMoveRight = true;
	}
	public void ButtonRightUp()
	{
		triggerMoveRight = false;
	}
}
