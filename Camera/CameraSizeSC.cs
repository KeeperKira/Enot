using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class CameraSizeSC : MonoBehaviour {
	
	public float offsetSize = 4.0f;
	public float Speed = 2;
	Camera cam;

	// Use this for initialization
	void Start () 
	{
		cam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		cam.orthographicSize = Mathf.Lerp(cam.orthographicSize,offsetSize,Speed*Time.deltaTime);
	}
}
