using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMapSC : MonoBehaviour {

	public float speed =1.0f; 
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
		{
			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			transform.Translate(touchDeltaPosition.x * speed, touchDeltaPosition.y * speed, 0);
			
			//screen.width;
			
			if(transform.position.x > 0)
				transform.position = new Vector2 (0, transform.position.y);
			if(transform.position.y > 0)
				transform.position = new Vector2 (transform.position.x, 0);
			
			if(transform.position.x < -1280)
				transform.position = new Vector2 (-1280, transform.position.y);
			if(transform.position.y < -720)
				transform.position = new Vector2 (transform.position.x, -720);
		}
		
	}
}
