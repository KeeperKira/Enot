using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositionSC : MonoBehaviour {
	
	public Vector3 Offset; 
	public float Speed = 2; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.localPosition = Vector3.Lerp(transform.localPosition,Offset,Speed*Time.deltaTime);
	}
}
//Debug.Log(" AssetBundle not found");