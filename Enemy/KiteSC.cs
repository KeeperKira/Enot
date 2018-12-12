using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiteSC : Enemy {
	
	public float speed = 7;
	private Rigidbody2D rb;
	private  Vector2 move;
	

	// Use this for initialization
	void Start () 
	{
		Destroy(gameObject,20);	
		rb = GetComponent<Rigidbody2D>();
        float angle;
        float playerSpeed = PlayerRB.velocity.magnitude;
        Vector2 distance;

        distance = transform.position - Plane.position ;

        if (playerSpeed <= 0.1f)
            angle = 0;
        else
            angle = Vector2.SignedAngle(PlayerRB.velocity,distance);
      
        if (playerSpeed >= speed)
            playerSpeed = speed - 0.1f;
        float sinA = (playerSpeed * Mathf.Sin(Mathf.Deg2Rad * angle))/speed;

        float dist=0;
		dist = Vector2.Distance(Plane.position, transform.position);
		
		move = (Plane.position - transform.position)/dist;
        //Debug.Log(Mathf.Asin(sinA));
        move = rot(move,Mathf.Asin(sinA));

        rb.velocity = move * speed;

        if (move.x >= 0)
        {
            Vector2 Scale;
            Scale = transform.localScale;
            Scale.x = -Scale.x;
            transform.localScale = Scale;
        }

    }
	
	// Update is called once per frame
	void Update () 
	{

	}
	
	void FixedUpdate()
	{
		

	}
	
	Vector2 rot(Vector2 vec2,float angle )
	{
		Vector2 Res;
		Res.x = vec2.x*Mathf.Cos(angle) - vec2.y*Mathf.Sin(angle);
		Res.y = vec2.x*Mathf.Sin(angle) + vec2.y*Mathf.Cos(angle);
		return Res;
	}
}
//Debug.Log(" AssetBundle not found");