using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsSC : MonoBehaviour {
	
	public float speed =1;
	private Vector3 position;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void FixedUpdate() 
	{

		;	
		
		if(transform.position.x<-25)
		{
			position = transform.position;
			position.x=26f;
			transform.position = position;
		}		
		else
		{
			position = transform.position;
			position.x-=1;
			transform.position = Vector3.Lerp(transform.position, position, speed * Time.deltaTime);
		}
			
	}
}
