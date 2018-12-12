using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetSC : MonoBehaviour {
	
	public float Size = 4.0f;
	public Vector3	Offset ;
	public CameraPositionSC cameraPosition;
	public CameraSizeSC optCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Player")
		{
			cameraPosition.Offset = Offset;
			optCamera.offsetSize = Size;
		}
	}
	void OnTriggerExit2D(Collider2D col)
	{
		if(col.gameObject.tag == "Player")
		{
			cameraPosition.Offset = new Vector3(0,0,-10);
			optCamera.offsetSize = 4.0f;
		}
	}
}
//Debug.Log(" AssetBundle not found");