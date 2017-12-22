using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollLayerSC : MonoBehaviour {
	
	public float		Speed = 0.1f;
	private Vector2		CameraStartPos;
	private Vector2		CameraPos;
	GameObject Camera ;
	
	// Use this for initialization
	void Start () 
	{
		Camera = GameObject.Find("Main Camera");
		CameraStartPos = Camera.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		CameraPos = Camera.transform.position;
		Vector3 delPos;
		delPos = (CameraStartPos - CameraPos);
		delPos *=Speed;
		
		delPos.z = this.transform.position.z;
		this.transform.position = delPos;

	}
}
