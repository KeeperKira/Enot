using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Sprite;

public class HedgehogAI : MonoBehaviour {
	
	public float speed = 2;
	private SpriteRenderer sbody;
	private Transform startPoint,finishPoint,goToPoint;
	private Transform sPoint,fPoint;
	private GameObject body;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () 
	{
		sPoint = transform.Find("StartPoint");
		fPoint = transform.Find("FinishPoint");
		body = transform.Find("Body").gameObject;
		rb = body.GetComponent<Rigidbody2D>();
		
		startPoint = sPoint;
		finishPoint = fPoint;
		goToPoint = startPoint;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void FixedUpdate()
	{
		float dist;
		dist = body.transform.position.x-goToPoint.position.x;
		if(dist>0)
			moveLeft();
		else
			moveRight();
			
		dist = Mathf.Abs(dist);
		if(dist<=0.5f)
		{
			if(goToPoint == startPoint)
				goToPoint = finishPoint;
			else
				goToPoint = startPoint;
		}
	
		sPoint = startPoint;
		fPoint = finishPoint;
		
	}
	
	void moveLeft()
	{
		if(body.transform.localScale.x < 0)
			body.transform.localScale = new  Vector3  (-body.transform.localScale.x,body.transform.localScale.y,0);
		
		Vector2 movement = new Vector2(-speed , rb.velocity.y);
		rb.velocity = movement;	
	}
	
	void moveRight()
	{
		if(body.transform.localScale.x > 0)
			body.transform.localScale = new  Vector3  (-body.transform.localScale.x,body.transform.localScale.y,0);
		
		Vector2 movement = new Vector2(speed , rb.velocity.y);
		rb.velocity = movement;	
		
	}
}
