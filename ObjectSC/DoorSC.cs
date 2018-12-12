using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSC : MonoBehaviour {
	
	private Transform door,onPosition,offPosition,lever;
	private Vector3 point;

	// Use this for initialization
	void Start () 
	{
		door = transform.Find("door");
		lever = transform.Find("lever");
		onPosition = transform.Find("onPosition");
		offPosition = transform.Find("offPosition");
		
		
	}
	
	// Update is called once per frame
	void Update () 
	{


	}
	void FixedUpdate()
	{
		
		if(lever.rotation.z>0.4f)
		{
			point = offPosition.position;
		}
		if(lever.rotation.z<-0.4f)
		{
			point = onPosition.position;
		}
		
		Vector3  move;
		float dist = Vector3.Distance(door.position,point);
		
		if(dist > 0.1f)
		{
			move = (point-door.position)/10;
			door.position += move;
		}

	
	}
}
