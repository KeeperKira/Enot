using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveToPlayer : MonoBehaviour {
	
	public Transform CameraPosition;
	public float Speed =5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = Vector3.Lerp(transform.position,CameraPosition.position,Speed*Time.deltaTime);		
	}
	
	void FixedUpdate() 
	{
		
		
	}
}
