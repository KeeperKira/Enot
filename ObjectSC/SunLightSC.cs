using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunLightSC : MonoBehaviour {
	
	public float amplitude = 2;
	public float frec =1;
	private Vector3 pos,NewPos;

	// Use this for initialization
	void Start () {
		
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		NewPos = pos;
		NewPos.x = pos.x+(amplitude *Mathf.Sin(Time.time*frec));
		transform.position = NewPos;
	}
}
